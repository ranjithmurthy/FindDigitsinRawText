# FindDigitsinRawText

# Task

In the attached text file, numbers (3, 2, 1, 4, 5) are encoded with horizontal and vertical bars.

Create a program  that reads the text file, recognizes the numbers, and displays them on the screen. 
The spacing (number of spaces) between the individual numbers is not always uniform because the file is created manually. 
Therefore, if necessary, these could be adapted to simplify the task.

# Objectives:
1. Structuring the program so that a developer team of several people can work on it at the same time.
2. Individual modules must be independent, interchangeable and well-tested.
 


FindDigitsinRawText is a simple WPF which is able to extract digits from txt file.

```
---   ---    |  |   |	-----
 /     _|    |  |___|	|___
 \    |	     |      |       |
--    ---    |	    |	____|
|  |   |   -----
|  |___|   |___
|      |       |
|      |   ____|   
```
# Expected Output

3 2 1 4 5 1 4 5 

# The input file are stored in directory 

  - Import a txt  file by just clicking a button and watch it magically convert to digits
 

You can also:
  - Modify the txt  files

```csharp
public class Digit
    {
        public string Number { get; set; }
        public string Top { get; set; }
        public string TopMiddle { get; set; }
        public string BottomMiddle { get; set; }
        public string Bottom { get; set; }
   }
  ```      
# Note: Our assumptions
  - we have  standard encoding txt for each digit
  - We assumne 4 lines will land up a each line in digit



### Testing 

FindDigitsInRawTextDataUnitTestProject added few testcases while development which is intended to expand more testcase:


### Installation

Open solution file in VisualStudio 20017/2015 


### Development


### Todos

 - Found some issues for  number 5 and 4 
 - Problems when there is invaild spacing between 

License
----
MIT


**Free Software, Hell Yeah!**

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)


