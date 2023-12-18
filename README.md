## Center Image In Frame

I notice that you're using `Aspect="AspectFill"` and the intellisense help for this property states:
>Some parts may be clipped in order to fill the view.

[![intellisense][1]][1]

In other words, when it expands to fill the Height aspect, it may cut off the image to the right making it appear uncentered.
___
If I reproduce your code using `Aspect.Fill` (and also I am now filling the view with the `Frame`) with these changes it seems to stay centered. Is this any closer to what you're going for?

[![animation][2]][2]

```xaml
<Frame BorderColor="Transparent" 
    CornerRadius="8" 
    WidthRequest="780" 
    HeightRequest="640"  
    HorizontalOptions="Fill" 
    Margin="130"  
    x:Name="ImageFrame"
    BackgroundColor="LightGreen">
    <Image Margin="-20" 
        x:Name="MainImage" 
        HorizontalOptions="Center"
        VerticalOptions="Center"
        Aspect="Fill"
        Source="frog.png"/>
</Frame>
```




  [1]: https://i.stack.imgur.com/0zntV.png
  [2]: https://i.stack.imgur.com/QwLJv.jpg