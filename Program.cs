var orderString = @"{""id"":""123"",""date"":""03/08/2022""}";
// var orderString = @"{""id"":""123"",""date"":""03333/08/2022""}";
// var orderString = @"{""id"":""123"",""date"":""15/08/2022""}";
// var orderString = @"{""id"":""123"",""date"":""2022-08-03""}";


// Native C#
var order = System.Text.Json.JsonSerializer.Deserialize<Order>(orderString, JsonOptions.Options);

Console.WriteLine($"Order ID: {order?.Id}");
Console.WriteLine($"Order Date: {order?.Date3.ToString()}");
Console.WriteLine($"Order Date: {order?.Date3.ToString("dd/MM/yyyy")}");


Console.WriteLine("\n");


// Newtonsoft.Json
var order2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Order>(orderString);

Console.WriteLine($"Order ID: {order2?.Id}");
Console.WriteLine($"Order Date: {order2?.Date3.ToString()}");
Console.WriteLine($"Order Date: {order2?.Date3.ToString("dd/MM/yyyy")}");


if (order != null) OrderRepository.Save(order);