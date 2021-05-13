# LearningSandbox Introduction
The interesting code snippets and some common thing implementation investigated, learned, or just revisited during learning process.
The motivation behind this projet is reminding myself about some fun behavior that CLR or C# compiler can produce. 
However, main goal is have fun and enjoy learning process.

# Project sections
- The boxing-ILdasm solution contains very simple value type boxing example. Using this example and 
some other free tools provided by CLR or VS we can have a better picture of all boxing cases in our
solution.
Using ILdasm.exe and navigating to the right section of IL code we can see the following picture.
![ildasm](https://github.com/[omelianlevkovych]/[LearningSandbox]/blob/[main]/src/Boxing-Ildasm/SimpleBoxing/resources/capture.png?raw=true)
Also, by invoking the following command: 
Ildasm.exe yourcomponent.dll /text | findstr box
we can generate a text file with all cases where the boxing occures.


# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)