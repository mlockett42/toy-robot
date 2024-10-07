# Toy Robot
Author: Mark Lockett

## How to run
Open in Visual Studio 2022 on Windows. Select ToyRobot.Runner as the startup project. Then run it.

## How to run the unit tests
Go to Test Explorer under the View menu and click the 'Run All Tests' button

## Commentary on this application

I used Australian English spelling for method and variable names. Normally I use US English for publicly available open source code and Australia English for internal applications, because that is what most of the intended audience 

Files of similar functions should be grouped together in folders (eg exceptions). But don't create folders with only one file in them.

Report errors by sub-classing our custom exception class (ToyRobotException). This allows us the catch errors which are from our user easily while framework errors cause their default behaviour (of making the program exit).

Keep the git history so you can see my progress and understand my thinking of how I put it together (hopefully)

Going to assume that

```
RIGHT will rotate the Toy Robot 90 degrees left (anti-clockwise/counter-clockwise).
```
This appears to be deliberately left in to check I carefully read the spec. It would be very embarassing if I hadn't noticed it!!

Also the spec includes some examples which overturn my assumptions (I had zero as the northern most row, but zero is the Southern most row).

I used Strong Inject as a dependency inject framework because that is my go to choice in Dotnet land because of performance. I used a Dependency Injection framework to make writing unit tests viable.

I ran dotnet format on the code. I am suspicous I didn't format everything as it only found one issue.

