A quick implimentation of API endpoints.

Petshop controller is an example of hooking up to some businesslogic to perform a service.  Example right now will provide the price of a dog 
based of of Age of dog, day of week, and dog breed.  Unit tests have been added.  This can be enhanced by making it more generic.  Currently its dog focused, however 
most petshops sell more kinds of pets.

DogController is an example of a rest api with basic crud operations.  To enhance, the service should be pulling/saving to a db or Filesystem to persist data
Another enhancement would be to use an actual domain model vs using the data transfer object.
