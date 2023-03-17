REST API Etteplan

The API is implemented for the maintenance tasks associated with each device. All CRUD are present. 
Each Maitenance task is linked with a Factory device. A Maitenance task can not be added without
linking it with a Factory device. 

The CRUD explained further:

Using the http POST request. When this method is used a new task needs a Discription, 
Severity (Critical, Important, Unimportant), Status (Open, Closed) and the DeviceId are required
in the parameter of this method. 

Using the http PUT request. This shall update the maitenance task with new information given. Only the registered
time shall never be updated.

There are Unit Tests present that show that the API works

Git:


How to run this API
	1. Clone the attached project file
	2. Update the connection string in appsettings.json
	3. Run the solution

