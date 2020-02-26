Improvised part of Document Db in 2014

Definition and Properties:

Cosmos- Well ordered big universe for database

Planet scale-user using across the world, get the data faster. Bring the database to the destination, has a concept of primary db and Read/secondary db using replication. 
Has strong consistency to read same data from any place in the world without any leaks. 
Bounded staleness: Set a specific time and display the same data for that specific time. 
Consistent Prefix: User data presented in the same sequence as of primary data to maintain the consistency.
Eventual Consistency: can have data at any time with no other clients waiting.

A choice to have a strong consistent(low Performance) or eventual consistancy(High Performance)


Json Db- Store data in Jason Format

Multi-API-Can use any api to get the database, eg. SQL, MONGO(key value pad), Cassandra etc.


To connect the C# to data base we need to relate these links:


 public int id {get; set;}
Public string name {get; set;}

Static void main
{
Client = new DocumentClient(new Uri (EndpointUrl), PrimaryKey);
}

Endpoint URL: @"https://anamol.documents.azure.com:443/";
Primary Key:
@"0RHWNJNjbuCiL4VQmXn7AjwfNVjnMxqxkEAmGyvH3OyeBwC4rWSliUAZM9wkFQDbhAAsDnLN11TqU3QYLceWqA==";  

Cosmos db :
	• Schema free, can store multiple variable different columns, Can have different type of data, like string, 
	• Unlimited Scaling
	• Document DB(2015): use to support only jason format,  
	• No relation: cant have joint
	• Multi model support

Collection: it store the data 
Some how similar to table in SQL
Structure of collection is different than table

Documents: can have any type of data, 
Some how similar to rows in SQL

Cosmos DB does not support joins between collection

Partition Key: Suppose many document in  Cosmos db, we define some partition key, we share in  cosmos db and spilit my database and  keep in different location 

Throughput: indicate the performance of the collection,  in digits; 
Cosmos db is asking how much performance do you want for this collection. The more the throughput, the more performance

