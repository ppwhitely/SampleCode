A quick implimentation of API endpoints.

The Petshop controller is an example of businesslogic being hooked up to perform a service. The example currently will provide the price of a dog 
based off the following criteria: age, day of week, and breed.  Unit tests have also been added.  This can be enhanced by making it more generic.  Currently its dog focused and most petshops sell more than dogs.

DogController is an example of a rest api with basic crud operations.  To enhance, the service should be pulling/saving to a db or Filesystem to persist data
Another enhancement would be to use an actual domain model vs using the data transfer object.
