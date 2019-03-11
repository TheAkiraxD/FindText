# FindText
A simple C# program that finds a determined text using the foundation of genetic algorithms.

![Alt Text](https://raw.githubusercontent.com/TheAkiraxD/FindText/master/FindText/preview_gif2.gif)

### About Genetic Algorithms
To know more details about Genetic Algorithms I strongly recommend the article [An Introduction to Genetic Algorithms](https://www.whitman.edu/Documents/Academics/Mathematics/2014/carrjk.pdf) from Jenna Carr.

### Configuring the program
You can change the default setup of FindText in these lines below in the `Form1.cs` file. You can play with those parameters to see if you can get best results.

```
Genetic Text = new Genetic("To be or not to be.", 300, 10);
```

Parameters:

* First parameter is the goal phrase. The program will work to find this out. The standard goal phrase is `"To be or not to be."` as this line shows,  but you can change it  to something else. Remember that long phrases can take a long time to be found.
* Second parameter is the initial population for each generation. For default it's set as `300`.
* The third and last parameter is the mutation rate. For default  it's set as `10`. This means that at each iteration there is 10% chance of each character changes for another random one.
