# FantasyFun

## Database

https://www.kaggle.com/datasets/hugomathien/soccer

## Homework

### Lesson 1

1. Create Player model in c# based on database model (weight and height is not needed).
2. Create PlayerAttributes model in c# based on database model (we need only first 5 columns - rest is not needed).
3. Create PlayersController.
4. Create Get method in PlayersController which returns player name and overall rating by given in as a parameter.
5. Create Get method in PlayersController which returns ALL players with given overall.

Update:
Ref 4:
Make default game week as 01-03-2015. Given player id returns player name and overall rating closest before default game week.

Ref 5:
Make default game week as 01-03-2015. Given overall returns ALL players (DISTINICT) which has this overall at the time default or earlier default game week. Take 100 first results.

### Lesson 2

Encapsulate all endpoint with ActionResult proper objects.
