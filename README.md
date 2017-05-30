LeetSpeak Specifications:

User can input  single word, then compares that word to a list of inputted words,  to check to see which words are anagrams'
The program will check the length of the single word provided, split it into an array of characters, and Array.Sort() it.
Any word length that is equal to the length of the single word provided will be checked.
If the word passes the previous check, split the word into an array of characters.
Array.Sort() the current word and compare each index with the initial word's index.
If the current index of the test word and the current index of the initial word match up completely for the entirety of the for loop, it's an anagram!


## Specifications
 |Behavior| Input (User Action/Selection)| Output (Program Action)|
 |---|---|---|
 |Program will accept a string from user |"hello" | "hello"|
 |Program will convert inputted string to array |"hello" | "h", "e", "l", "l", "o"|
 |Program will go through new array |no input require | no output for this step|
 |Program will replace "e" with "3" |"hello"|"h3llo"|
 |Program will replace "o" with "0" |"h3llo" |"h3ll0"|
 |Program will replace "I" with "1" | "Indigo"| "1ndigo"|
 |Program will replace "t" with "7" |"tomato" |"70ma70"|
 |Program will replace "s" with "z" unless it's the first letter of the word |"master"|"maz7er"|
