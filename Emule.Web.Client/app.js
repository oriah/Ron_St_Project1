var server = 'http://ron1.ori-pc.com';

function onConnect() {

  var isLoginOK = LogInToServer();
  if (!isLoginOK) {
    //alert('wrong user name and/or password !');
    debugger;
    $('#lblStatus')[0].innerHTML = 'wrong user name and/or password !';
    $('#lblStatus2')[0].innerHTML = '';
    return;
  } else {
    $('#lblStatus')[0].innerHTML = '';
    var iterations = 0;
    var timerId = setInterval(function () {

      //debugger;
      $('#lblStatus2')[0].innerHTML = 'You\'re Connected!!';
      setTimeout(function () {

        $('#lblStatus2')[0].innerHTML = '';

        iterations++;
        if (iterations >= 3)
          clearInterval(timerId);
      }, 500);
    }, 700);
  }

  //enable back the new message controls
  $btn = document.getElementById('tbxNewMessage');
  $tbx = document.getElementById('btnNewMessage');
  $btn.disabled = false;
  $tbx.disabled = false;

  //starts listening to messages.
  setInterval(readMessagesOne, 3000);



  function LogInToServer() {


    //console.log(`I'm ${age} years old!`)

    var username = $('#username').val();
    var password = $('#password').val();
    //alert(username);

    //reach server and check if user+pass is ok
    var res = $.ajax({
      method: 'GET',
      url: server + `/home/login?username=${username}&password=${password}`,
      async: false,
      //context: document.body,
      success: function (data) {

        //alert(data);
        //$(this).addClass("done");
      }
    }).responseText;

    return res == 'True';
  }







  function loadXMLDoc1()    //using vanilla js
  {
    var xmlhttp = new XMLHttpRequest();

    xmlhttp.onreadystatechange = function () {
      if (xmlhttp.readyState == XMLHttpRequest.DONE) {   // XMLHttpRequest.DONE == 4
        if (xmlhttp.status == 200) {
          document.getElementById("myDiv").innerHTML = xmlhttp.responseText;
        }
        else if (xmlhttp.status == 400) {
          alert('There was an error 400');
        }
        else {
          alert('something else other than 200 was returned');
        }
      }
    };

    xmlhttp.open("GET", "ajax_info.txt", true);
    xmlhttp.send();
  }

  function loadXMLDoc2()    //using jquery
  {
    $.ajax({
      url: "test.html",
      context: document.body,
      success: function () {
        $(this).addClass("done");
      }
    });
  }

}



function readMessagesOne(username)     //periodic check for new messages
{
  var username = $('#username').val();
  var res = $.ajax({
    method: 'POST',
    url: server + `/home/read`,
    async: false,
    data:
    {
      userName: username
    },
    //context: document.body,
    success: function (data) {

      if (data.length == 0)
        return;

      //var strData = JSON.stringify(data);
      //alert(strData);
      //debugger;
      $('#tbxChat').val($('#tbxChat').val() + data[0].UserName + ": " + data[0].Message + '\r\n');
      //alert(data);
      //$(this).addClass("done");
    }
  }).responseText;
}

function saveFile(data) {

  var $file = document.getElementById("file"); // $('#file').val();
  var file = $file.files[0];
  debugger;

  var formData = new FormData();
  formData.append('file', file);


  //sends to server (async)
  $.ajax({
    method: 'POST',
    url: server + `/api/testfile`,
    async: true,
    processData: false, // tell jQuery not to process the data
    contentType: false, // tell jQuery not to set contentType
    data: formData,
    //context: document.body,
    success: function(data) {

      debugger;
      alert(data);
      //$(this).addClass("done");
    }
  });
}
