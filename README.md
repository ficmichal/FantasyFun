# FantasyFun

## Database

https://www.kaggle.com/datasets/hugomathien/soccer

## Learning log

### Interfaces
Branch: https://github.com/ficmichal/FantasyFun/tree/feature/-learn-interfaces

Main commit: https://github.com/ficmichal/FantasyFun/compare/main...feature/-learn-interfaces

### HTTP codes
Branch: https://github.com/ficmichal/FantasyFun/tree/feature/learn-http-codes

Main commit: https://github.com/ficmichal/FantasyFun/compare/main...feature/learn-http-codes

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

Encapsulate all endpoints with ActionResult proper objects.

### Lesson 3

1. Separate query in Players controller into two parts (more readable approach).
2. Use Depencendy Injection in TeamsController.
3. Move GameDateTime (2015-03-01) to settings (configuration) and inject them by constructor in PlayersController (you probably need to regsiter binded class in .NET Service Register (use builder.Services.AddScoped<>() after GetSection().Get()).
