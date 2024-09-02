var sql = "SELECT * FROM UserAccount WHERE Username = '" + username "'";
SqlCommand command = new SqlCommand(sql , connection);
SqlDataReader reader = command.ExecuteReader();

var name = '@Html.Raw(HttpUtility.JavaScriptStringEncode(Model.Name))';


<img src="http://example.com/foo.jpg" alt="" onload="alert('xss')" />


  
