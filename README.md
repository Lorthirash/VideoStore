# VideoStore

## 1. Part

The goal of this exercise is to design and implement a simple inventory control system for a small video rental store.
Define at least two classes: a Video class to model a video and a VideoStore class to model the actual store.
<p>

### Video Class:

Assume that an object of Video class has the following attributes:
- a title
- a flag to indicate whether it is rented out or not
- a collection of rating values (use List)
<p>
Add instance variables for each of these attributes to the Video class.
<p>

In addition, you will need to add methods (to set the values of the instance variables) corresponding to the followings:
 - being rented out
 - being returned
 - receiving a rating
<p>

### VideoStore Class:
The VideoStore class will contain at least an instance variable that references a collection (use List) of videos.
The VideoStore will contain the following methods:
- addVideo(String): add a new video (by title) to the inventory
- rentVideo(String): check out a video (by title)
- returnVideo(String): return a video to the store
- receiveRating(String, int) : take a user's rating for a video (between 1 and 5 values)
- listInventory(): list the whole inventory of videos in the store
<p>
<p>

### Summary of design specs:
- store a library of videos identified by title
- allow a video to indicate whether it is currently rented out
- allow users to rate a video
- print the store's inventory, listing for each video:
  - its title
  - its average rating
  - whether it is rented out or on the shelves
- optional: display the percentage of favorable ratings (percentage of 4 or 5 values together)
<p>
<p>

## 2. Part
Add a new feature: modify the definition of addRating() in the Video class in the following way:
- if the rating count is lower than or equal to 4, then nothing is changed
- if the rating count is higher than 4, then find the highest and the lowest ratings and discard them (and their counts)
- when finding the average, if you end up with multiple max/min ratings, only discard one of them

#### Example 1:

- ratings entered: 1, 2, 4
- rating count = 3
- avg =  2.33

#### Example 2:

- ratings entered: 5, 4, 1, 4, 5, 5, 3, 2
- rating count = 6 (8 - 2)
- discarded Max = 5
- discarded Min = 1
- avg = 3.83

#### Example 3:

- ratings entered: 5, 5, 5, 5, 4, 4
- rating count = 4 (6 - 2)
- discarded Max = 5
- discarded Min = 4
- avg = 4.75
<p>

## 3. Part
We are going to add some Customers to the VideoStore.
A Customer is modeled by a class that has instance variables for:
- the name
- an array/collection for the history of movies that the Customer has rented
<p>
The VideoStore keeps track of the customers, you can add a Customer to the store with the enrollCustomer() method.
<p>

## 4. Part
In this exercise, you should add a feature to the VideoStore so that the system can recommend another movie that a Customer may like,
based on their rental history: 
- this should be the highest-rated video that the Customer has not yet rented out.
<p>
Implement the suggestVideo() method and update the rentVideo() method so that the video in question is added to the Customer's history.

