void test()
{
	
//Constructing Payload
shipmentsList = List(); 
tracking_data = { "trackingId": "MSDU1062938", "destinationCountry": "VALENCIA" };
shipmentsList.add(tracking_data);
data  = Map();
data.put("shipments",shipmentsList);
data.put("language","en");
data.put("apiKey","eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1aWQiOiI2ZGIwNTM2MC0zNTFkLTExZWUtYjM1Yi1iMzExMjZiYjg5ZWEiLCJzdWJJZCI6IjY0ZDBlMjljZTVlNmIzMWIzZjhjZjE5NyIsImlhdCI6MTY5MTQxMTEwMH0.FUWg8nY4-QSuwO9QYNhC5xscZFElFZOtNkFzBuZ6hlw");

headerMap = Map();
headerMap.put("accept","application/json");
headerMap.put("Content-Type","application/json");

//Calling Service
response = postUrl("https://parcelsapp.com/api/v3/shipments/tracking",data.toString(),headerMap);

//Parsing Response
result = response.toJSONList();

eta_date = result.getJSON("shipments").getJSON("lastState").getJSON("date");
eta_datetime =  toDateTime(eta_date);
info eta_datetime.getDate(); 
info eta_datetime.getTime();
}