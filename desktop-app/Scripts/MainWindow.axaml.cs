using Avalonia.Controls;
using Avalonia.Interactivity;

namespace linuxjourney_desktop;

public partial class MainWindow : Window
{

    static bool onGrassHopper = false;
    static bool onJourneyMan = false;
    static bool onNetworking = false;
    static bool onCourses = false;
    static bool onLessons = false;
    static bool onText = false;

    static bool onCourseOne = false;
    static bool onCourseTwo = false;
    static bool onCourseThree = false;
    static bool onCourseFour = false;
    static bool onCourseFive = false;
    static bool onCourseSix = false;
    static bool onCourseSeven = false;
    static bool onCourseEight = false;
    static bool onCourseNine = false;
    static bool onCourseTen = false;
    static bool onCourseEleven = false;
    static bool onCourseTwelve = false;
    static bool onCourseThirteen = false;
    static bool onCourseFourteen = false;
    static bool onCourseFifteen = false;
    static bool onCourseSixteen = false;
    static bool onCourseSeventeen = false;
    static bool onCourseEighteen = false;
    static bool onCourseNineteen = false;
    static bool onCourseTwenty = false;
    static bool onCourseTwentyOne = false;
    static bool onCourseTwentyTwo = false;
    

    public MainWindow()
    {
        InitializeComponent();
    }

    public void goBackArrow_Click(object sender, RoutedEventArgs e)
    {
         if (onGrassHopper || onJourneyMan || onNetworking && grasshopperButton.IsVisible == true) { goBackArrow.IsVisible = false; }


         if (coursesLabel.IsVisible) 
         { 
            onCourses = true; onLessons = false; onText = false; 
         }


         if (lessonsLabel.IsVisible) 
         { 
            onLessons = true; onCourses = false; onText = false; 
         }


         if (grasshopperButton.IsVisible == false && coursesLabel.IsVisible == false && lessonsLabel.IsVisible == false)
         {
            onText = true; onCourses = false; onLessons = false;
         }



        if (onCourses && onGrassHopper)
        {
           grasshopperButton.IsVisible = true;
           journeymanButton.IsVisible = true;
           networkingButton.IsVisible = true;


           coursesLabel.IsVisible = false;

           courseOneButton.IsVisible = false;
           courseTwoButton.IsVisible = false;
           courseThreeButton.IsVisible = false;
           courseFourButton.IsVisible = false;
           courseFiveButton.IsVisible = false;
           courseSixButton.IsVisible = false;
           courseSevenButton.IsVisible = false;
           courseEightButton.IsVisible = false;
        }

        if (onCourses && onJourneyMan)
        {
           grasshopperButton.IsVisible = true;
           journeymanButton.IsVisible = true;
           networkingButton.IsVisible = true;


           coursesLabel.IsVisible = false;

           courseNineButton.IsVisible = false;
           courseTenButton.IsVisible = false;
           courseElevenButton.IsVisible = false;
           courseTwelveButton.IsVisible = false;
           courseThirteenButton.IsVisible = false;
           courseFourteenButton.IsVisible = false;
           courseFifteenButton.IsVisible = false;

           
        }

        if(onCourses && onNetworking)
        {
           grasshopperButton.IsVisible = true;
           journeymanButton.IsVisible = true;
           networkingButton.IsVisible = true;


           coursesLabel.IsVisible = false;

           courseSixteenButton.IsVisible = false;
           courseSeventeenButton.IsVisible = false;
           courseEighteenButton.IsVisible = false;
           courseNineteenButton.IsVisible = false;
           courseTwentyButton.IsVisible = false;
           courseTwentyOneButton.IsVisible = false;
           courseTwentyTwoButton.IsVisible = false;
        }

        if (onLessons && onGrassHopper)
        {
           goBackArrow.IsVisible = true;
           coursesLabel.IsVisible = true;
           lessonsLabel.IsVisible = false;

           courseOneButton.IsVisible = true;
           courseTwoButton.IsVisible = true;
           courseThreeButton.IsVisible = true;
           courseFourButton.IsVisible = true;
           courseFiveButton.IsVisible = true;
           courseSixButton.IsVisible = true;
           courseSevenButton.IsVisible = true;
           courseEightButton.IsVisible = true;

           lessonOneButton.IsVisible = false;
           lessonTwoButton.IsVisible = false;
           lessonThreeButton.IsVisible = false;
           lessonFourButton.IsVisible = false;
           lessonFiveButton.IsVisible = false;
           lessonSixButton.IsVisible = false;
           lessonSevenButton.IsVisible = false;
           lessonEightButton.IsVisible = false;
           lessonNineButton.IsVisible = false;
           lessonTenButton.IsVisible = false;
           lessonElevenButton.IsVisible = false;
           lessonTwelveButton.IsVisible = false;
           lessonThirteenButton.IsVisible = false;
           lessonFourteenButton.IsVisible = false;
           lessonFifteenButton.IsVisible = false;
           lessonSixteenButton.IsVisible = false;
           lessonSeventeenButton.IsVisible = false;
           lessonEighteenButton.IsVisible = false;
           lessonNineteenButton.IsVisible = false;
           lessonTwentyButton.IsVisible = false;
           lessonTwentyOneButton.IsVisible = false;
           lessonTwentyTwoButton.IsVisible = false;
           lessonTwentyThreeButton.IsVisible = false;
           lessonTwentyFourButton.IsVisible = false;
           lessonTwentyFiveButton.IsVisible = false;
           lessonTwentySixButton.IsVisible = false;
           lessonTwentySevenButton.IsVisible = false;
           lessonTwentyEightButton.IsVisible = false;
           lessonTwentyNineButton.IsVisible = false;
           lessonThirtyButton.IsVisible = false;
           lessonThirtyOneButton.IsVisible = false;
           lessonThirtyTwoButton.IsVisible = false;
           lessonThirtyThreeButton.IsVisible = false;
           lessonThirtyFourButton.IsVisible = false;
           lessonThirtyFiveButton.IsVisible = false;
           lessonThirtySixButton.IsVisible = false;
           lessonThirtySevenButton.IsVisible = false;
           lessonThirtyEightButton.IsVisible = false;
           lessonThirtyNineButton.IsVisible = false;
           lessonFortyButton.IsVisible = false;
           lessonFortyOneButton.IsVisible = false;
           lessonFortyTwoButton.IsVisible = false;
           lessonFortyThreeButton.IsVisible = false;
           lessonFortyFourButton.IsVisible = false;
           lessonFortyFiveButton.IsVisible = false;
           lessonFortySixButton.IsVisible = false;
           lessonFortySevenButton.IsVisible = false;
           lessonFortyEightButton.IsVisible = false;
           lessonFortyNineButton.IsVisible = false;
           lessonFiftyButton.IsVisible = false;
           lessonFiftyOneButton.IsVisible = false;
           lessonFiftyTwoButton.IsVisible = false;
           lessonFiftyThreeButton.IsVisible = false;
           lessonFiftyFourButton.IsVisible = false;
           lessonFiftyFiveButton.IsVisible = false;
           lessonFiftySixButton.IsVisible = false;
           lessonFiftySevenButton.IsVisible = false;
           lessonFiftyEightButton.IsVisible = false;
           lessonFiftyNineButton.IsVisible = false;
           lessonSixtyButton.IsVisible = false;
           lessonSixtyOneButton.IsVisible = false;
           lessonSixtyTwoButton.IsVisible = false;
           lessonSixtyThreeButton.IsVisible = false;
           lessonSixtyFourButton.IsVisible = false;
           lessonSixtyFiveButton.IsVisible = false;
           lessonSixtySixButton.IsVisible = false;
           lessonSixtySevenButton.IsVisible = false;
           lessonSixtyEightButton.IsVisible = false;
           lessonSixtyNineButton.IsVisible = false;
           lessonSeventyButton.IsVisible = false;
           lessonSeventyOneButton.IsVisible = false;
           lessonSeventyTwoButton.IsVisible = false;
           lessonSeventyThreeButton.IsVisible = false;
           lessonSeventyFourButton.IsVisible = false;
           lessonSeventyFiveButton.IsVisible = false;
           lessonSeventySixButton.IsVisible = false;
           lessonSeventySevenButton.IsVisible = false;
           lessonSeventyEightButton.IsVisible = false;
           lessonSeventyNineButton.IsVisible = false;
           lessonEightyButton.IsVisible = false;
           lessonEightyOneButton.IsVisible = false;
           lessonEigthyTwoButton.IsVisible = false;
           lessonEightyThreeButton.IsVisible = false;
           lessonEightyFourButton.IsVisible = false;
           lessonEightyFiveButton.IsVisible = false;
           lessonEightySixButton.IsVisible = false;
           lessonEightySevenButton.IsVisible = false;
           lessonEightyEightButton.IsVisible = false;
           lessonEightyNineButton.IsVisible = false;
           lessonNinetyButton.IsVisible = false;
        }

        if (onLessons && onJourneyMan)
        {
           goBackArrow.IsVisible = true;
           coursesLabel.IsVisible = true;
           lessonsLabel.IsVisible = false;

           courseNineButton.IsVisible = true;
           courseTenButton.IsVisible = true;
           courseElevenButton.IsVisible = true;
           courseTwelveButton.IsVisible = true;
           courseThirteenButton.IsVisible = true;
           courseFourteenButton.IsVisible = true;
           courseFifteenButton.IsVisible = true;


           lessonNinetyOneButton.IsVisible = false;
           lessonNinetyTwoButton.IsVisible = false;
           lessonNinetyThreeButton.IsVisible = false;
           lessonNinetyFourButton.IsVisible = false;
           lessonNinetyFiveButton.IsVisible = false;
           lessonNinetySixButton.IsVisible = false;
           lessonNinetySevenButton.IsVisible = false;
           lessonNinetyEightButton.IsVisible = false;
           lessonNinetyNineButton.IsVisible = false;
           lessonOneHundredButton.IsVisible = false;
           lessonOneHundredOneButton.IsVisible = false;
           lessonOneHundredTwoButton.IsVisible = false;
           lessonOneHundredThreeButton.IsVisible = false;
           lessonOneHundredFourButton.IsVisible = false;
           lessonOneHundredFiveButton.IsVisible = false;
           lessonOneHundredSixButton.IsVisible = false;
           lessonOneHundredSevenButton.IsVisible = false;
           lessonOneHundredEightButton.IsVisible = false;
           lessonOneHundredNineButton.IsVisible = false;
           lessonOneHundredNineExtraButton.IsVisible = false;
           lessonOneHundredTenButton.IsVisible = false;
           lessonOneHundredElevenButton.IsVisible = false;
           lessonOneHundredTwelveButton.IsVisible = false;
           lessonOneHundredThirteenButton.IsVisible = false;
           lessonOneHundredFourteenButton.IsVisible = false;
           lessonOneHundredFifteenButton.IsVisible = false;
           lessonOneHundredSixteenButton.IsVisible = false;
           lessonOneHundredSeventeenButton.IsVisible = false;
           lessonOneHundredEighteenButton.IsVisible = false;
           lessonOneHundredNineteenButton.IsVisible = false;
           lessonOneHundredTwentyButton.IsVisible = false;
           lessonOneHundredTwentyOneButton.IsVisible = false;
           lessonOneHundredTwentyTwoButton.IsVisible = false;
           lessonOneHundredTwentyThreeButton.IsVisible = false;
           lessonOneHundredTwentyFourButton.IsVisible = false;
           lessonOneHundredTwentyFiveButton.IsVisible = false;
           lessonOneHundredTwentySixButton.IsVisible = false;
           lessonOneHundredTwentySevenButton.IsVisible = false;
           lessonOneHundredTwentyEightButton.IsVisible = false;
           lessonOneHundredTwentyNineButton.IsVisible = false;
           lessonOneHundredThirtyButton.IsVisible = false;
           lessonOneHundredThirtyOneButton.IsVisible = false;
           lessonOneHundredThirtyTwoButton.IsVisible = false;
           lessonOneHundredThirtyThreeButton.IsVisible = false;
           lessonOneHundredThirtyFourButton.IsVisible = false;
           lessonOneHundredThirtyFiveButton.IsVisible = false;
           lessonOneHundredThirtySixButton.IsVisible = false;
           lessonOneHundredThirtySevenButton.IsVisible = false;
           lessonOneHundredThirtyEightButton.IsVisible = false;
           lessonOneHundredThirtyNineButton.IsVisible = false;
           lessonOneHundredFortyButton.IsVisible = false;
           lessonOneHundredFortyOneButton.IsVisible = false;
        }

        if (onLessons && onNetworking)
        {
           goBackArrow.IsVisible = true;
           coursesLabel.IsVisible = true;
           lessonsLabel.IsVisible = false;

           courseSixteenButton.IsVisible = true;
           courseSeventeenButton.IsVisible = true;
           courseEighteenButton.IsVisible = true;
           courseNineteenButton.IsVisible = true;
           courseTwentyButton.IsVisible = true;
           courseTwentyOneButton.IsVisible = true;
           courseTwentyTwoButton.IsVisible = true;

           lessonOneHundredFortyTwoButton.IsVisible = false;
           lessonOneHundredFortyThreeButton.IsVisible = false;
           lessonOneHundredFortyFourButton.IsVisible = false;
           lessonOneHundredFortyFiveButton.IsVisible = false;
           lessonOneHundredFortySixButton.IsVisible = false;
           lessonOneHundredFortySevenButton.IsVisible = false;
           lessonOneHundredFortyEightButton.IsVisible = false;
           lessonOneHundredFortyNineButton.IsVisible = false;
           lessonOneHundredFiftyButton.IsVisible = false;
           lessonOneHundredFiftyOneButton.IsVisible = false;
           lessonOneHundredFiftyTwoButton.IsVisible = false;
           lessonOneHundredFiftyThreeButton.IsVisible = false;
           lessonOneHundredFiftyFourButton.IsVisible = false;
           lessonOneHundredFiftyFiveButton.IsVisible = false;
           lessonOneHundredFiftySixButton.IsVisible = false;
           lessonOneHundredFiftySevenButton.IsVisible = false;
           lessonOneHundredFiftyEightButton.IsVisible = false;
           lessonOneHundredFiftyNineButton.IsVisible = false;
           lessonOneHundredSixtyButton.IsVisible = false;
           lessonOneHundredSixtyOneButton.IsVisible = false;
           lessonOneHundredSixtyTwoButton.IsVisible = false;
           lessonOneHundredSixtyThreeButton.IsVisible = false;
           lessonOneHundredSixtyFourButton.IsVisible = false;
           lessonOneHundredSixtyFiveButton.IsVisible = false;
           lessonOneHundredSixtySixButton.IsVisible = false;
           lessonOneHundredSixtySevenButton.IsVisible = false;
           lessonOneHundredSixtyEightButton.IsVisible = false;
           lessonOneHundredSixtyNineButton.IsVisible = false;
           lessonOneHundredSeventyButton.IsVisible = false;
           lessonOneHundredSeventyOneButton.IsVisible = false;
           lessonOneHundredSeventyTwoButton.IsVisible = false;
           lessonOneHundredSeventyThreeButton.IsVisible = false;
           lessonOneHundredSeventyFourButton.IsVisible = false;
           lessonOneHundredSeventyFiveButton.IsVisible = false;
           lessonOneHundredSeventySixButton.IsVisible = false;
           lessonOneHundredSeventySevenButton.IsVisible = false;
           lessonOneHundredSeventyEightButton.IsVisible = false;
           lessonOneHundredSeventyNineButton.IsVisible = false;
           lessonOneHundredEightyButton.IsVisible = false;
           lessonOneHundredEightyOneButton.IsVisible = false;
           lessonOneHundredEightyTwoButton.IsVisible = false;
           lessonOneHundredEightyThreeButton.IsVisible = false;
           lessonOneHundredEightyFourButton.IsVisible = false;
           lessonOneHundredEightyFiveButton.IsVisible = false;
        }

        if (onText && onCourseOne)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneButton.IsVisible = true;
           lessonTwoButton.IsVisible = true;
           lessonThreeButton.IsVisible = true;
           lessonFourButton.IsVisible = true;
           lessonFiveButton.IsVisible = true;
           lessonSixButton.IsVisible = true;
           lessonSevenButton.IsVisible = true;
           lessonEightButton.IsVisible = true;
           lessonNineButton.IsVisible = true;
           lessonTenButton.IsVisible = true;
        }

        if (onText && onCourseTwo)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonElevenButton.IsVisible = true;
           lessonTwelveButton.IsVisible = true;
           lessonThirteenButton.IsVisible = true;
           lessonFourteenButton.IsVisible = true;
           lessonFifteenButton.IsVisible = true;
           lessonSixteenButton.IsVisible = true;
           lessonSeventeenButton.IsVisible = true;
           lessonEighteenButton.IsVisible = true;
           lessonNineteenButton.IsVisible = true;
           lessonTwentyButton.IsVisible = true;
           lessonTwentyOneButton.IsVisible = true;
           lessonTwentyTwoButton.IsVisible = true;
           lessonTwentyThreeButton.IsVisible = true;
           lessonTwentyFourButton.IsVisible = true;
           lessonTwentyFiveButton.IsVisible = true;
           lessonTwentySixButton.IsVisible = true;
           lessonTwentySevenButton.IsVisible = true;
           lessonTwentyEightButton.IsVisible = true;
           lessonTwentyNineButton.IsVisible = true;
        }

        if (onText && onCourseThree)
        { 
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;


           lessonThirtyButton.IsVisible = true;
           lessonThirtyOneButton.IsVisible = true;
           lessonThirtyTwoButton.IsVisible = true;
           lessonThirtyThreeButton.IsVisible = true;
           lessonThirtyFourButton.IsVisible = true;
           lessonThirtyFiveButton.IsVisible = true;
           lessonThirtySixButton.IsVisible = true;
           lessonThirtySevenButton.IsVisible = true;
           lessonThirtyEightButton.IsVisible = true;
           lessonThirtyNineButton.IsVisible = true;
           lessonFortyButton.IsVisible = true;
           lessonFortyOneButton.IsVisible = true;
           lessonFortyTwoButton.IsVisible = true;
           lessonFortyThreeButton.IsVisible = true;
           lessonFortyFourButton.IsVisible = true;
           lessonFortyFiveButton.IsVisible = true;
        }

        if (onText && onCourseFour)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonFortySixButton.IsVisible = true;
           lessonFortySevenButton.IsVisible = true;
           lessonFortyEightButton.IsVisible = true;
           lessonFortyNineButton.IsVisible = true;
           lessonFiftyButton.IsVisible = true;
           lessonFiftyOneButton.IsVisible = true;
           lessonFiftyTwoButton.IsVisible = true;
           lessonFiftyThreeButton.IsVisible = true;
           lessonFiftyFourButton.IsVisible = true;
           lessonFiftyFiveButton.IsVisible = true;
           lessonFiftySixButton.IsVisible = true;
           lessonFiftySevenButton.IsVisible = true;
           lessonFiftyEightButton.IsVisible = true;
        }

        if (onText && onCourseFive)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonFiftyNineButton.IsVisible = true;
           lessonSixtyButton.IsVisible = true;
           lessonSixtyOneButton.IsVisible = true;
           lessonSixtyTwoButton.IsVisible = true;
           lessonSixtyThreeButton.IsVisible = true;
           lessonSixtyFourButton.IsVisible = true;

        }
        
        if (onText && onCourseSix)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonSixtyFiveButton.IsVisible = true;
           lessonSixtySixButton.IsVisible = true;
           lessonSixtySevenButton.IsVisible = true;
           lessonSixtyEightButton.IsVisible = true;
           lessonSixtyNineButton.IsVisible = true;
           lessonSeventyButton.IsVisible = true;
           lessonSeventyOneButton.IsVisible = true;
           lessonSeventyTwoButton.IsVisible = true;
        }

        if (onText && onCourseSeven)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonSeventyThreeButton.IsVisible = true;
           lessonSeventyFourButton.IsVisible = true;
           lessonSeventyFiveButton.IsVisible = true;
           lessonSeventySixButton.IsVisible = true;
           lessonSeventySevenButton.IsVisible = true;
           lessonSeventyEightButton.IsVisible = true;
           lessonSeventyNineButton.IsVisible = true;
           lessonEightyButton.IsVisible = true;
           lessonEightyOneButton.IsVisible = true;
           lessonEigthyTwoButton.IsVisible = true;
           lessonEightyThreeButton.IsVisible = true;
        }

        if (onText && onCourseEight)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonEightyFourButton.IsVisible = true;
           lessonEightyFiveButton.IsVisible = true;
           lessonEightySixButton.IsVisible = true;
           lessonEightySevenButton.IsVisible = true;
           lessonEightyEightButton.IsVisible = true;
           lessonEightyNineButton.IsVisible = true;
           lessonNinetyButton.IsVisible = true;
        }

        if (onText && onCourseNine)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonNinetyOneButton.IsVisible = true;
           lessonNinetyTwoButton.IsVisible = true;
           lessonNinetyThreeButton.IsVisible = true;
           lessonNinetyFourButton.IsVisible = true;
           lessonNinetyFiveButton.IsVisible = true;
           lessonNinetySixButton.IsVisible = true;
           lessonNinetySevenButton.IsVisible = true;
        }

        if (onText && onCourseTen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonNinetyEightButton.IsVisible = true;
           lessonNinetyNineButton.IsVisible = true;
           lessonOneHundredButton.IsVisible = true;
           lessonOneHundredOneButton.IsVisible = true;
           lessonOneHundredTwoButton.IsVisible = true;
           lessonOneHundredThreeButton.IsVisible = true;
           lessonOneHundredFourButton.IsVisible = true;
           lessonOneHundredFiveButton.IsVisible = true;
           lessonOneHundredSixButton.IsVisible = true;
           lessonOneHundredSevenButton.IsVisible = true;
           lessonOneHundredEightButton.IsVisible = true;
           lessonOneHundredNineButton.IsVisible = true;
           lessonOneHundredNineExtraButton.IsVisible = true;
        }

        if (onText && onCourseEleven)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredTenButton.IsVisible = true;
           lessonOneHundredElevenButton.IsVisible = true;
           lessonOneHundredTwelveButton.IsVisible = true;
           lessonOneHundredThirteenButton.IsVisible = true;
           lessonOneHundredFourteenButton.IsVisible = true;
        }

        if (onText && onCourseTwelve)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredFifteenButton.IsVisible = true;
           lessonOneHundredSixteenButton.IsVisible = true;
           lessonOneHundredSeventeenButton.IsVisible = true;
           lessonOneHundredEighteenButton.IsVisible = true;
           lessonOneHundredNineteenButton.IsVisible = true;
           lessonOneHundredTwentyButton.IsVisible = true;
        }

        if (onText && onCourseThirteen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredTwentyOneButton.IsVisible = true;
           lessonOneHundredTwentyTwoButton.IsVisible = true;
           lessonOneHundredTwentyThreeButton.IsVisible = true;
           lessonOneHundredTwentyFourButton.IsVisible = true;
           lessonOneHundredTwentyFiveButton.IsVisible = true;
           lessonOneHundredTwentySixButton.IsVisible = true;
           lessonOneHundredTwentySevenButton.IsVisible = true;
        }

        if (onText && onCourseFourteen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredTwentyEightButton.IsVisible = true;
           lessonOneHundredTwentyNineButton.IsVisible = true;
           lessonOneHundredThirtyButton.IsVisible = true;
           lessonOneHundredThirtyOneButton.IsVisible = true;
           lessonOneHundredThirtyTwoButton.IsVisible = true;
           lessonOneHundredThirtyThreeButton.IsVisible = true;
           lessonOneHundredThirtyFourButton.IsVisible = true;
           lessonOneHundredThirtyFiveButton.IsVisible = true;
        }

        if (onText && onCourseFifteen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredThirtySixButton.IsVisible = true;
           lessonOneHundredThirtySevenButton.IsVisible = true;
           lessonOneHundredThirtyEightButton.IsVisible = true;
           lessonOneHundredThirtyNineButton.IsVisible = true;
           lessonOneHundredFortyButton.IsVisible = true;
           lessonOneHundredFortyOneButton.IsVisible = true;
 
        }

        if (onText && onCourseSixteen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredFortyTwoButton.IsVisible = true;
           lessonOneHundredFortyThreeButton.IsVisible = true;
           lessonOneHundredFortyFourButton.IsVisible = true;
           lessonOneHundredFortyFiveButton.IsVisible = true;
           lessonOneHundredFortySixButton.IsVisible = true;
 
        }

        if (onText && onCourseSeventeen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;
 
           lessonOneHundredFortySevenButton.IsVisible = true;
           lessonOneHundredFortyEightButton.IsVisible = true;
           lessonOneHundredFortyNineButton.IsVisible = true;
           lessonOneHundredFiftyButton.IsVisible = true;
           lessonOneHundredFiftyOneButton.IsVisible = true;
           lessonOneHundredFiftyTwoButton.IsVisible = true;
           lessonOneHundredFiftyThreeButton.IsVisible = true;
           lessonOneHundredFiftyFourButton.IsVisible = true;
           lessonOneHundredFiftyFiveButton.IsVisible = true;
 
        }

        if (onText && onCourseEighteen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredFiftySixButton.IsVisible = true;
           lessonOneHundredFiftySevenButton.IsVisible = true;
           lessonOneHundredFiftyEightButton.IsVisible = true;
           lessonOneHundredFiftyNineButton.IsVisible = true;
           lessonOneHundredSixtyButton.IsVisible = true;
           lessonOneHundredSixtyOneButton.IsVisible = true;
           lessonOneHundredSixtyTwoButton.IsVisible = true;
 
        }
        
        if (onText && onCourseNineteen)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredSixtyThreeButton.IsVisible = true;        
           lessonOneHundredSixtyFourButton.IsVisible = true;        
           lessonOneHundredSixtyFiveButton.IsVisible = true;        
           lessonOneHundredSixtySixButton.IsVisible = true;        
           lessonOneHundredSixtySevenButton.IsVisible = true;        
           lessonOneHundredSixtyEightButton.IsVisible = true;        
           lessonOneHundredSixtyNineButton.IsVisible = true;        
        }

        if (onText && onCourseTwenty)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredSeventyButton.IsVisible = true;
           lessonOneHundredSeventyOneButton.IsVisible = true;
           lessonOneHundredSeventyTwoButton.IsVisible = true;
           lessonOneHundredSeventyThreeButton.IsVisible = true;
           lessonOneHundredSeventyFourButton.IsVisible = true;
        }

        if (onText && onCourseTwentyOne)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredSeventyFiveButton.IsVisible = true;
           lessonOneHundredSeventySixButton.IsVisible = true;
           lessonOneHundredSeventySevenButton.IsVisible = true;
           lessonOneHundredSeventyEightButton.IsVisible = true;
           lessonOneHundredSeventyNineButton.IsVisible = true;
        }

        if (onText && onCourseTwentyTwo)
        {
           goBackArrow.IsVisible = true;
           lessonsLabel.IsVisible = true;

           lessonContent.IsVisible = false;

           lessonOneHundredEightyButton.IsVisible = true;
           lessonOneHundredEightyOneButton.IsVisible = true;
           lessonOneHundredEightyTwoButton.IsVisible = true;
           lessonOneHundredEightyThreeButton.IsVisible = true;
           lessonOneHundredEightyFourButton.IsVisible = true;
           lessonOneHundredEightyFiveButton.IsVisible = true;
        }


    }




    //''Sections'' Clicks

    public void grasshopperButton_Click(object sender, RoutedEventArgs e)
    {
        onGrassHopper = true;
        onJourneyMan = false;
        onNetworking = false;
        goBackArrow.IsVisible = true;

        grasshopperButton.IsVisible=false;
        journeymanButton.IsVisible=false;
        networkingButton.IsVisible=false;

        coursesLabel.IsVisible=true;

        courseOneButton.IsVisible=true;
        courseTwoButton.IsVisible=true;
        courseThreeButton.IsVisible=true;
        courseFourButton.IsVisible=true;
        courseFiveButton.IsVisible=true;
        courseSixButton.IsVisible=true;
        courseSevenButton.IsVisible=true;
        courseEightButton.IsVisible=true;

        
    }

    public void journeymanButton_Click(object sender, RoutedEventArgs e)
    {
        onJourneyMan = true;
        onGrassHopper = false;
        onNetworking = false;
        goBackArrow.IsVisible = true;

        grasshopperButton.IsVisible=false;
        journeymanButton.IsVisible=false;
        networkingButton.IsVisible=false;

        coursesLabel.IsVisible=true;

        courseNineButton.IsVisible=true;
        courseTenButton.IsVisible=true;
        courseElevenButton.IsVisible=true;
        courseTwelveButton.IsVisible=true;
        courseThirteenButton.IsVisible=true;
        courseFourteenButton.IsVisible=true;
        courseFifteenButton.IsVisible=true;
    }

    public void networkingButton_Click(object sender, RoutedEventArgs e)
    {
        onNetworking = true;
        onGrassHopper = false;
        onJourneyMan = false;
        goBackArrow.IsVisible = true;

        grasshopperButton.IsVisible=false;
        journeymanButton.IsVisible=false;
        networkingButton.IsVisible=false;

        coursesLabel.IsVisible=true;

        courseSixteenButton.IsVisible=true;
        courseSeventeenButton.IsVisible=true;
        courseEighteenButton.IsVisible=true;
        courseNineteenButton.IsVisible=true;
        courseTwentyButton.IsVisible=true;
        courseTwentyOneButton.IsVisible=true;
        courseTwentyTwoButton.IsVisible=true;
    }

    //GrassHopper Courses Clicks

    public void courseOneButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = true;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false; 
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonOneButton.IsVisible=true;
        lessonTwoButton.IsVisible=true;
        lessonThreeButton.IsVisible=true;
        lessonFourButton.IsVisible=true;
        lessonFiveButton.IsVisible=true;
        lessonSixButton.IsVisible=true;
        lessonSevenButton.IsVisible=true;
        lessonEightButton.IsVisible=true;
        lessonNineButton.IsVisible=true;
        lessonTenButton.IsVisible=true;
    }

    public void courseTwoButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = true;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonElevenButton.IsVisible=true;
        lessonTwelveButton.IsVisible=true;
        lessonThirteenButton.IsVisible=true;
        lessonFourteenButton.IsVisible=true;
        lessonFifteenButton.IsVisible=true;
        lessonSixteenButton.IsVisible=true;
        lessonSeventeenButton.IsVisible=true;
        lessonEighteenButton.IsVisible=true;
        lessonNineteenButton.IsVisible=true;
        lessonTwentyButton.IsVisible=true;
        lessonTwentyOneButton.IsVisible=true;
        lessonTwentyTwoButton.IsVisible=true;
        lessonTwentyThreeButton.IsVisible=true;
        lessonTwentyFourButton.IsVisible=true;
        lessonTwentyFiveButton.IsVisible=true;
        lessonTwentySixButton.IsVisible=true;
        lessonTwentySevenButton.IsVisible=true;
        lessonTwentyEightButton.IsVisible=true;
        lessonTwentyNineButton.IsVisible=true;
    }

    public void courseThreeButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = true;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonThirtyButton.IsVisible=true;
        lessonThirtyOneButton.IsVisible=true;
        lessonThirtyTwoButton.IsVisible=true;
        lessonThirtyThreeButton.IsVisible=true;
        lessonThirtyFourButton.IsVisible=true;
        lessonThirtyFiveButton.IsVisible=true;
        lessonThirtySixButton.IsVisible=true;
        lessonThirtySevenButton.IsVisible=true;
        lessonThirtyEightButton.IsVisible=true;
        lessonThirtyNineButton.IsVisible=true;
        lessonFortyButton.IsVisible=true;
        lessonFortyOneButton.IsVisible=true;
        lessonFortyTwoButton.IsVisible=true;
        lessonFortyThreeButton.IsVisible=true;
        lessonFortyFourButton.IsVisible=true;
        lessonFortyFiveButton.IsVisible=true;
    }

    public void courseFourButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = true;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonFortySixButton.IsVisible=true;
        lessonFortySevenButton.IsVisible=true;
        lessonFortyEightButton.IsVisible=true;
        lessonFortyNineButton.IsVisible=true;
        lessonFiftyButton.IsVisible=true;
        lessonFiftyOneButton.IsVisible=true;
        lessonFiftyTwoButton.IsVisible=true;
        lessonFiftyThreeButton.IsVisible=true;
        lessonFiftyFourButton.IsVisible=true;
        lessonFiftyFiveButton.IsVisible=true;
        lessonFiftySixButton.IsVisible=true;
        lessonFiftySevenButton.IsVisible=true;
        lessonFiftyEightButton.IsVisible=true;
    }

    public void courseFiveButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = true;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonFiftyNineButton.IsVisible=true;
        lessonSixtyButton.IsVisible=true;
        lessonSixtyOneButton.IsVisible=true;
        lessonSixtyTwoButton.IsVisible=true;
        lessonSixtyThreeButton.IsVisible=true;
        lessonSixtyFourButton.IsVisible=true;
    }

    public void courseSixButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = true;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=true;
        lessonSixtySixButton.IsVisible=true;
        lessonSixtySevenButton.IsVisible=true;
        lessonSixtyEightButton.IsVisible=true;
        lessonSixtyNineButton.IsVisible=true;
        lessonSeventyButton.IsVisible=true;
        lessonSeventyOneButton.IsVisible=true;
        lessonSeventyTwoButton.IsVisible=true;
    }

    public void courseSevenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = true;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=true;
        lessonSeventyFourButton.IsVisible=true;
        lessonSeventyFiveButton.IsVisible=true;
        lessonSeventySixButton.IsVisible=true;
        lessonSeventySevenButton.IsVisible=true;
        lessonSeventyEightButton.IsVisible=true;
        lessonSeventyNineButton.IsVisible=true;
        lessonEightyButton.IsVisible=true;
        lessonEightyOneButton.IsVisible=true;
        lessonEigthyTwoButton.IsVisible=true;
        lessonEightyThreeButton.IsVisible=true;
    }

    public void courseEightButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = true;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonEightyFourButton.IsVisible=true;
        lessonEightyFiveButton.IsVisible=true;
        lessonEightySixButton.IsVisible=true;
        lessonEightySevenButton.IsVisible=true;
        lessonEightyEightButton.IsVisible=true;
        lessonEightyNineButton.IsVisible=true;
        lessonNinetyButton.IsVisible=true;
    }

    //JourneyMan Courses Clicks

    public void courseNineButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = true;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonNinetyOneButton.IsVisible=true;
        lessonNinetyTwoButton.IsVisible=true;
        lessonNinetyThreeButton.IsVisible=true;
        lessonNinetyFourButton.IsVisible=true;
        lessonNinetyFiveButton.IsVisible=true;
        lessonNinetySixButton.IsVisible=true;
        lessonNinetySevenButton.IsVisible=true;
    }

    public void courseTenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = true;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonNinetyEightButton.IsVisible=true;
        lessonNinetyNineButton.IsVisible=true;
        lessonOneHundredButton.IsVisible=true;
        lessonOneHundredOneButton.IsVisible=true;
        lessonOneHundredTwoButton.IsVisible=true;
        lessonOneHundredThreeButton.IsVisible=true;
        lessonOneHundredFourButton.IsVisible=true;
        lessonOneHundredFiveButton.IsVisible=true;
        lessonOneHundredSixButton.IsVisible=true;
        lessonOneHundredSevenButton.IsVisible=true;
        lessonOneHundredEightButton.IsVisible=true;
        lessonOneHundredNineButton.IsVisible=true;
        lessonOneHundredNineExtraButton.IsVisible=true;
    }


    public void courseElevenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = true;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=true;
        lessonOneHundredElevenButton.IsVisible=true;
        lessonOneHundredTwelveButton.IsVisible=true;
        lessonOneHundredThirteenButton.IsVisible=true;
        lessonOneHundredFourteenButton.IsVisible=true;
    }

    public void courseTwelveButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = true;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=true;
        lessonOneHundredSixteenButton.IsVisible=true;
        lessonOneHundredSeventeenButton.IsVisible=true;
        lessonOneHundredEighteenButton.IsVisible=true;
        lessonOneHundredNineteenButton.IsVisible=true;
        lessonOneHundredTwentyButton.IsVisible=true;
    }

    public void courseThirteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = true;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=true;
        lessonOneHundredTwentyTwoButton.IsVisible=true;
        lessonOneHundredTwentyThreeButton.IsVisible=true;
        lessonOneHundredTwentyFourButton.IsVisible=true;
        lessonOneHundredTwentyFiveButton.IsVisible=true;
        lessonOneHundredTwentySixButton.IsVisible=true;
        lessonOneHundredTwentySevenButton.IsVisible=true;
    }

    public void courseFourteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = true;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=true;
        lessonOneHundredTwentyNineButton.IsVisible=true;
        lessonOneHundredThirtyButton.IsVisible=true;
        lessonOneHundredThirtyOneButton.IsVisible=true;
        lessonOneHundredThirtyTwoButton.IsVisible=true;
        lessonOneHundredThirtyThreeButton.IsVisible=true;
        lessonOneHundredThirtyFourButton.IsVisible=true;
        lessonOneHundredThirtyFiveButton.IsVisible=true;
    }

    public void courseFifteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = true;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=true;
        lessonOneHundredThirtySevenButton.IsVisible=true;
        lessonOneHundredThirtyEightButton.IsVisible=true;
        lessonOneHundredThirtyNineButton.IsVisible=true;
        lessonOneHundredFortyButton.IsVisible=true;
        lessonOneHundredFortyOneButton.IsVisible=true;
    }


    //Networking Courses Clicks
    public void courseSixteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = true;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=true;
        lessonOneHundredFortyThreeButton.IsVisible=true;
        lessonOneHundredFortyFourButton.IsVisible=true;
        lessonOneHundredFortyFiveButton.IsVisible=true;
        lessonOneHundredFortySixButton.IsVisible=true;
  
    }

    public void courseSeventeenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = true;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=true;
        lessonOneHundredFortyEightButton.IsVisible=true;
        lessonOneHundredFortyNineButton.IsVisible=true;
        lessonOneHundredFiftyButton.IsVisible=true;
        lessonOneHundredFiftyOneButton.IsVisible=true;
        lessonOneHundredFiftyTwoButton.IsVisible=true;
        lessonOneHundredFiftyThreeButton.IsVisible=true;
        lessonOneHundredFiftyFourButton.IsVisible=true;
        lessonOneHundredFiftyFiveButton.IsVisible=true;
    }

    public void courseEighteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = true;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=true;
        lessonOneHundredFiftySevenButton.IsVisible=true;
        lessonOneHundredFiftyEightButton.IsVisible=true;
        lessonOneHundredFiftyNineButton.IsVisible=true;
        lessonOneHundredSixtyButton.IsVisible=true;
        lessonOneHundredSixtyOneButton.IsVisible=true;
        lessonOneHundredSixtyTwoButton.IsVisible=true;
    }

    public void courseNineteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = true;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=true;
        lessonOneHundredSixtyFourButton.IsVisible=true;
        lessonOneHundredSixtyFiveButton.IsVisible=true;
        lessonOneHundredSixtySixButton.IsVisible=true;
        lessonOneHundredSixtySevenButton.IsVisible=true;
        lessonOneHundredSixtyEightButton.IsVisible=true;
        lessonOneHundredSixtyNineButton.IsVisible=true;
    }

    public void courseTwentyButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = true;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = false;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=true;
        lessonOneHundredSeventyOneButton.IsVisible=true;
        lessonOneHundredSeventyTwoButton.IsVisible=true;
        lessonOneHundredSeventyThreeButton.IsVisible=true;
        lessonOneHundredSeventyFourButton.IsVisible=true;
    }

    public void courseTwentyOneButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = true;
        onCourseTwentyTwo = false;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=true;
        lessonOneHundredSeventySixButton.IsVisible=true;
        lessonOneHundredSeventySevenButton.IsVisible=true;
        lessonOneHundredSeventyEightButton.IsVisible=true;
        lessonOneHundredSeventyNineButton.IsVisible=true;
    }

    public void courseTwentyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        onCourseOne = false;
        onCourseTwo = false;
        onCourseThree = false;
        onCourseFour = false;
        onCourseFive = false;
        onCourseSix = false;
        onCourseSeven = false;
        onCourseEight = false;
        onCourseNine = false;
        onCourseTen = false;
        onCourseEleven = false;
        onCourseTwelve = false;
        onCourseThirteen = false;
        onCourseFourteen = false;
        onCourseFifteen = false;
        onCourseSixteen = false;
        onCourseSeventeen = false;
        onCourseEighteen = false;
        onCourseNineteen = false;
        onCourseTwenty = false;
        onCourseTwentyOne = false;
        onCourseTwentyTwo = true;


        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=true;
        lessonOneHundredEightyOneButton.IsVisible=true;
        lessonOneHundredEightyTwoButton.IsVisible=true;
        lessonOneHundredEightyThreeButton.IsVisible=true;
        lessonOneHundredEightyFourButton.IsVisible=true;
        lessonOneHundredEightyFiveButton.IsVisible=true;
    }


    //GrassHopper Lessons
    public void lessonOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Hey rookie! So you decided to dive into this wonderful world known as Linux? 
Well you better strap in, because it’s gonna be a long and hard road. My name is Penguin Pete and I’m here to guide you through this journey. 
Let’s get started with a little bit of backstory about Linux. 

To learn about how Linux came to be, let’s go back to the beginning to 1969 where Ken Thompson and Dennis Ritchie of Bell Laboratories developed the UNIX operating system. 
It was later rewritten in C to make it more portable and eventually became a widely used operating system. 
A decade or so later, Richard Stallman started working on the GNU (GNU is Not UNIX) project, the GNU kernel called Hurd, which unfortunately never came to completion. 
The GNU General Public License (GPL), a free software license, was also created as a result of this.

The kernel is the most important piece in the operating system. It allows the hardware to talk to the software. 
It also does a whole lot of other things, but we’ll dig into that in a different course. 
For now, just know that the kernel controls pretty much everything that happens on your system. 

During this time other efforts such as BSD, MINIX, etc were developed to be UNIX like-systems. 
However, one thing that all these UNIX like-systems had in common was the lack of a unified kernel. 

Then in 1991, a young fellow named Linus Torvalds started developing what we now know today as the Linux kernel.
        ";
    }

    public void lessonTwoButton_Click(object sender, RoutedEventArgs e)
    {
    
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In the previous lesson, we learned about the Linux kernel which powers millions of devices a day. 
One thing before we move forward, the term Linux is actually quite a misnomer, since it actually refers to the Linux kernel. 
However, many distributions use the Linux kernel so therefore are commonly known as Linux operating systems. 

A Linux system is divided into three main parts:


Hardware - This includes all the hardware that your system runs on as well as memory, CPU, disks, etc.
Linux Kernel - As we discussed above, the kernel is the core of the operating system. It manages the hardware and tells it how to interact with the system.
User Space - This is where users like yourself will be directly interacting with the system.


So the first step we’ll need to take is to install Linux on your machine. 
You have many options to choose from and this course will help inform you and get you started on choosing a Linux distribution. 

There are many Linux distributions to choose from, we’ll just go over the most popular options. 
        ";
    }

    public void lessonThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Debian is an operating system composed entirely of free and open-source software. 
It’s widely known and has been in development for over 20 years. 
There are three branches that you can use, Stable, Testing and Unstable. 

Stable is an overall good branch to be on. 
Testing and Unstable are rolling releases. 
This means that any incremental changes in those branches will eventually become Stable. 
For example, if you wanted to get to the next update from Windows 8 to Windows 10, you’ll have to do a complete Windows 10 installation. 
However being on the Testing release, you’ll automatically get updates until it becomes the next operating system release without having to do a full installation. 


Package Management:
Debian also uses Debian package management tools. 
Every Linux distribution installs and manages packages differently and they use different package management tools. 
We’ll get more into this in a later course. 


Configurability:
Debian may not get the latest updates, but it's extremely stable. 
If you want a good ""core"" operating system, this is the one for you.


Debian is an overall great operating system for any platform.

        ";
    }

    public void lessonFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Red Hat Enterprise Linux commonly referred to as RHEL is developed by Red Hat. 
RHEL has strict rules to restrict free re-distribution although it still provides source code for free.


Package Management:
RHEL uses a different package manager than Debian, RPM package manager, which we will eventually learn about as well.


Configurability:
RHEL-based operating systems will differ slightly from the Debian-based operating systems, most noticeably in package management. 
If you decide to go with RHEL it’s probably best if you know you’ll be working with it.


Uses:
As described by the name it's mostly used in enterprise, so if you need a solid server OS this would be a good one.
        ";
    }

    public void lessonFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
One of the most popular Linux distributions for personal machines is Ubuntu. 
Ubuntu also releases its own desktop environment manager Unity by default. 


Package Management:
Ubuntu is a Debian-based operating system developed by Canonical. 
So it uses a core Debian package management system.


Configurability:
Ubuntu is a great choice for a beginner who wants to get into Linux. 
Ubuntu offers ease of use and a great user interface experience that has led to its wide adoption. 
It’s widely used and supported and is most like other operating systems like OSX and Windows in terms of usability.


Uses:
Great for any platform, desktop, laptop and server.
        ";
        
    }

    public void lessonSixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Backed by Red Hat, the Fedora Project is community driven containing open-source and free software. 
Red Hat Enterprise Linux branches off Fedora, so think of Fedora as an upstream RHEL operating system. 
Eventually RHEL will get updates from Fedora after thorough testing and quality assurance. 
Think of Fedora as an Ubuntu equivalent that uses a Red Hat backend instead of Debian.


Package Management:
Uses Red Hat package manager.


Configurability:
If you want to use a Red Hat based operating system, this is a user friendly version.


Uses:
Fedora is great if you want a Red Hat based operating system without the price tag. 
Recommended for desktop and laptop.
        ";
    }

    public void lessonSevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        
        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Linux Mint is based off of Ubuntu. 
It uses Ubuntu’s software repositories so the same packages are available on both distributions. 
Linux Mint is preferred by others over Ubuntu because it doesn’t come with some of the proprietary software that Ubuntu includes such as Unity.


Package Management:
Since Linux Mint is Ubuntu based, it uses the Debian package manager.


Configurability:
Great user interface, great for beginners and less bloated than Ubuntu. 
In this course, I’ll be using Linux Mint, but any other distribution can be used. 


Uses:
Great for desktop and laptop.
        ";
        
    }

    public void lessonEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Gentoo offers ridiculous flexibility with the operating system at a price. 
It’s made for advanced users who don’t mind getting their hands dirty with the system.


Package Management:
Gentoo uses its own package management, Portage. 
The Portage package management is very modular and easy to maintain, which plays a big part in the operating system as a whole being very flexible.


Configurability:
If you’re just getting started with Linux and want to take a more difficult path, I’d choose Gentoo or Arch Linux as your distribution.


Uses:
Great for desktop and laptop.
        ";

    }

    public void lessonNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Arch is a lightweight and flexible Linux distribution driven 100% by the community. 
Similar to Debian, Arch uses a rolling release model so incremental updates eventually become the Stable release. 
You really need to get your hands dirty to understand the system and its functions, but in turn you get complete and total control of your system.


Package Management:
It uses its own package manager, Pacman, to install, update and manage packages. 


Configurability:
If you want a lightweight operating system and really want to understand Linux use Arch! 
There’s a bit of a learning curve, but for the hardcore Linux users, this is a great choice.


Uses:
Great for desktop and laptop. 
If you also have a small device such as a Raspberry Pi and need to stick a lightweight OS on it, you can’t go wrong with Arch.
        ";

    }

    public void lessonTenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneButton.IsVisible=false;
        lessonTwoButton.IsVisible=false;
        lessonThreeButton.IsVisible=false;
        lessonFourButton.IsVisible=false;
        lessonFiveButton.IsVisible=false;
        lessonSixButton.IsVisible=false;
        lessonSevenButton.IsVisible=false;
        lessonEightButton.IsVisible=false;
        lessonNineButton.IsVisible=false;
        lessonTenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
openSUSE Linux is created by the openSUSE Project. 
A community that promotes the use of Linux everywhere, working together in an open, transparent and friendly manner as part of the worldwide Free and Open Source Software community. 
openSUSE is the second oldest still running Linux Distributions and shares the base system with SUSE's award-winning SUSE Linux Enterprise products.


Package Management:
Uses RPM package manager.


Configurability:
openSUSE is a great choice for a new Linux user. 
It offers an easy to use graphical installer/administration application and a tiday base system, easy to tinker with. 
openSUSE includes everything you need to enjoy the Internet worry free of viruses/spy-ware and to live out your creativity, be it with your photos, videos, music or code.


Uses:
openSUSE Leap is fully capable of being used on a desktop PC and laptop.
        ";
    }

    //Command-Line Lessons
    public void lessonElevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The world is your oyster, or really the shell is your oyster. What is the shell? 
The shell is basically a program that takes your commands from the keyboard and sends them to the operating system to perform. 
If you’ve ever used a GUI, you’ve probably seen programs such as “Terminal” or “Console” these are just programs that launch a shell for you. 
Throughout this entire course we will be learning about the wonders of the shell. 


In this course we will use the shell program bash (Bourne Again shell). 
Almost all Linux distributions will default to the bash shell. 
There are other shells available such as ksh, zsh, tsch, but we won’t get into any of those. 


Let’s jump right in! 
Depending on the distribution your shell prompt might change, but for the most part it should adhere to the following format:
username@hostname:current_directory
pete@icebox:/home/pete $


Notice the $ at the end of the prompt? 
Different shells will have different prompts, in our case the $ is for a normal user using Bash, Bourne or Korn shell. 
You don't add the prompt symbol when you type the command, just know that it's there.


Let’s start with a simple command, echo. 
The echo command just prints out the text arguments to the display.

""echo Hello World""
        ";
        
    }

    public void lessonTwelveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Everything in Linux is a file, as you journey deeper into Linux you’ll understand this, but for now just keep that in mind. 
Every file is organized in a hierarchical directory tree. 
The first directory in the filesystem is aptly named the root directory. 
The root directory has many folders and files which you can store more folders and files, etc. 
Here is an example of what the directory tree looks like: 


|-- bin
|   |-- file1
|   |-- file2
|-- etc
|   |-- file3
|   `-- directory1
|       |-- file4
|       `-- file5
|-- home
|-- var


The location of these files and directories are referred to as paths. 
If you had a folder named home with a folder inside of it named pete and another folder in that folder called Movies, 
that path would look like this: /home/pete/Movies, pretty simple huh?


Navigation of the filesystem, much like real life is helpful if you know where you are and where you are going. 
To see where you are, you can use the pwd command, this command means “print working directory” and it just shows you which directory you are in, 
note the path stems from the root directory.

""pwd""


Where are you? Where am I? Give it a try!
        ";
     
    }

    public void lessonThirteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now that you know where you are, let’s see if we can move around the filesystem a bit. 
Remember we’ll need to navigate our way using paths. 
There are two different ways to specify a path, with absolute and relative paths. 


Absolute path: This is the path from the root directory. 
The root is the head honcho. 
The root directory is commonly shown as a slash. 
Every time your path starts with / it means you are starting from the root directory. 
For example, /home/pete/Desktop.


Relative path: This is the path from where you are currently in filesystem. 
If I was in location /home/pete/Documents and wanted to get to a directory inside Documents called taxes, 
I don’t have to specify the whole path from root like /home/pete/Documents/taxes, 
I can just go to taxes/ instead.


Now that you know how paths work, we just need something to help us change to the directory we want to. 
Luckily, we have cd or “change directory” to do that. 

""cd /home/pete/Pictures""

So now I've changed my directory location to /home/pete/Pictures.

Now from this directory I have a folder inside called Hawaii, I can navigate to that folder with:

""cd Hawaii""

Notice how I just used the name of the folder? It’s because I was already in /home/pete/Pictures.

It can get pretty tiring navigating with absolute and relative paths all the time, luckily there are some shortcuts to help you out. 

. (current directory). This is the directory you are currently in. </li>
.. (previous directory). Takes you to the directory above your current.</li>
~ (home directory). This directory defaults to your “home directory”. Such as /home/pete.</li>
- (previous directory). This will take you to the previous directory you were just at.</li>

""cd .""
""cd ..""
""cd ~""
""cd -""
Give them a try!
        ";
    }

    public void lessonFourteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now that we know how to move around the system, how do we figure out what is available to us? 
Right now it’s like we are moving around in the dark. 
Well, we can use the wonderful ls command to list directory contents. 
The ls command will list directories and files in the current directory by default, however you can specify which path you want to list the directories of.

""ls""
""ls /home/pete""


ls is a quite useful tool, it also shows you detailed information about the files and directories you are looking at.
Also note that not all files in a directory will be visible. 
Filenames that start with ""."" are hidden, you can view them however with the ls command and pass the -a flag to it (a for all). 

""ls -a""


There is also one more useful ls flag, -l for long. 
This shows a detailed list of files in a long format. 
This will show you detailed information, starting from the left: 
file permissions, 
number of links, 
owner name, 
owner group, 
file size, timestamp of last modification, 
and file/directory name. 

""ls -l""

pete@icebox:~$ ls -l
total 80
drwxr-x--- 7 pete penguingroup   4096 Nov 20 16:37 Desktop
drwxr-x--- 2 pete penguingroup   4096 Oct 19 10:46  Documents
drwxr-x--- 4 pete penguingroup   4096 Nov 20 09:30 Downloads
drwxr-x--- 2 pete penguingroup   4096 Oct  7 13:13   Music
drwxr-x--- 2 pete penguingroup   4096 Sep 21 14:02 Pictures
drwxr-x--- 2 pete penguingroup   4096 Jul 27 12:41   Public
drwxr-x--- 2 pete penguingroup   4096 Jul 27 12:41   Templates
drwxr-x--- 2 pete penguingroup   4096 Jul 27 12:41   Videos


Commands have things called flags (or arguments or options, whatever you want to call it) 
to add more functionality. See how we added -a and -l, well you can add them both together with -la. 
The order of the flags determines which order it goes in, most of the time this doesn’t really matter so you can also do ls -al and it would still work.

""ls -la""
        ";
    }

    public void lessonFifteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let’s learn how to make some files. 
A very simple way is to use the touch command. 
Touch allows you to the create new empty files.

""touch mysuperduperfile""


And boom, new file! 


Touch is also used to change timestamps on existing files and directories. 
Give it a try, do an ls -l on a file and note the timestamp, then touch that file and it will update the timestamp. 

There are many other ways to create files that involve other things like redirection and text editors, but we’ll get to that in the Text Manipulation course.
        ";
 
    }

    public void lessonSixteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In the previous lesson we learned about touch, let’s go back to that for a bit. 
Did you notice that the filename didn’t conform to standard naming like you’ve probably seen with other operating systems like Windows? 
Normally you would expect a file called banana.jpeg and expect a JPEG picture file. 


In Linux, filenames aren’t required to represent the contents of the file. 
You can create a file called funny.gif that isn’t actually a GIF. 


To find out what kind of file a file is, you can use the file command. 
It will show you a description of the file’s contents.

""file banana.jpg""
        ";
        
    }

    public void lessonSeventeenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We’re almost done navigating files, but first let’s learn how to read a file. 
A simple command to use is the cat command, short for concatenate. 
It not only displays file contents but it can combine multiple files and show you the output of them. 

""cat dogfile birdfile""


It’s not great for viewing large files and it’s only meant for short content. 
There are many other tools that we use to view larger text files that we’ll discuss in the next lesson.
        ";
        
    }

    public void lessonEighteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
If you are viewing text files larger than a simple output, less is more. 
(There is actually a command called more that does something similar, so this is ironic.) 
The text is displayed in a paged manner, so you can navigate through a text file page by page. 


Go ahead and look at the contents of a file with less. 
Once you’re in the less command, you can actually use other keyboard commands to navigate in the file. 

""less /home/pete/Documents/text1""


Use the following command to navigate through less: 

q - Used to quit out of less and go back to your shell.
Page up, Page down, Up and Down - Navigate using the arrow keys and page keys.
g - Moves to beginning of the text file.
G - Moves to the end of the text file.
/search - You can search for specific text inside the text document. Prefacing the words you want to search with /
h - If you need a little help about how to use less while you’re in less, use help.
        ";
     
    }

    public void lessonNineteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In your shell, there is a history of the commands that you previously entered, you can actually look through these commands. 
This is quite useful when you want to find and run a command you used previously without actually typing it again.

""history""


Want to run the same command you did before, just hit the up arrow. 
Want to run the previous command without typing it again? Use ""!!"".
If you typed cat file1 and want to run it again, you can actually just go !! and it will run the last command you ran. 


Another history shortcut is ctrl-R, this is the reverse search command, 
if you hit ctrl-R and you start typing parts of the command you want it will show you matches and you can just navigate through them by hitting the ctrl-R key again. 
Once you found the command you want to use again, just hit the Enter key.


Our terminal is getting a little cluttered no? 
Let’s do a little cleanup, use the clear command to clear up your display.

""clear""


There that looks better doesn’t it? 

While we are talking about useful things, one of the most useful features in any command-line environment is tab completion. 
If you start typing the beginning of a command, file, directory, etc and hit the Tab key, 
it will autocomplete based on what it finds in the directory you are searching as long as you don’t have any other files that start with those letters. 
For example if you were trying to run the command chrome, you can type chr and press Tab and it will autocomplete chrome.
        ";
 
    }

    public void lessonTwentyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let’s start making some copies of these files. 
Much like copy and pasting files in other operating systems, the shell gives us an even simpler way of doing that. 

""cp mycoolfile /home/pete/Documents/cooldocs""


""mycoolfile"" is the file you want to copy and ""/home/pete/Documents/cooldocs"" is where you are copying the file to.


You can copy multiple files and directories as well as use wildcards. 
A wildcard is a character that can be substituted for a pattern based selection, giving you more flexibility with searches. 
You can use wildcards in every command for more flexibility.

* the wildcard of wildcards, it's used to represent all single characters or any string.
? used to represent one character
[] used to represent any character within the brackets


""cp *.jpg /home/pete/Pictures""

This will copy all files with the .jpg extension in your current directory to the Pictures directory.

A useful command is to use the -r flag, this will recursively copy the files and directories within a directory. 


Try to do a cp on a directory that contains a couple of files to your Documents directory. 
Didn’t work did it? Well that’s because you’ll need to copy over the files and directories inside as well with -r command.

""cp -r Pumpkin/ /home/pete/Documents""


One thing to note, if you copy a file over to a directory that has the same filename, the file will be overwritten with whatever you are copying over. 
This is no bueno if you have a file that you don’t want to get accidentally overwritten. 
You can use the -i flag (interactive) to prompt you before overwriting a file. 

""cp -i mycoolfile /home/pete/Pictures""
        ";
 
    }

    public void lessonTwentyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Used for moving files and also renaming them. 
Quite similar to the cp command in terms of flags and functionality. 


You can rename files like this:

""mv oldfile newfile""


Or you can actually move a file to a different directory: 

""mv file2 /home/pete/Documents""


And move more than one file:

""mv file_1 file_2 /somedirectory""


You can rename directories as well:

""mv directory1 directory2""


Like cp, if you mv a file or directory it will overwrite anything in the same directory. 
So you can use the -i flag to prompt you before overwriting anything.


""mv -i directory1 directory2""


Let’s say you did want to mv a file to overwrite the previous one. 
You can also make a backup of that file and it will just rename the old version with a ~. 

""mv -b directory1 directory2""
        ";
 
    }

    public void lessonTwentyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We’re gonna need some directories to store all these files we’ve been working on. 
The mkdir command (Make Directory) is useful for that, it will create a directory if it doesn’t already exist. 
You can even make multiple directories at the same time.

""mkdir books paintings""


You can also create subdirectories at the same time with the -p (parent flag).

""mkdir -p books/hemmingway/favorites""
        ";
 
    }

    public void lessonTwentyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now I think we have too many files, let’s remove some files. 
To remove files you can use the rm command. The rm (remove) command is used to delete files and directories. 

""rm file1""


Take caution when using rm, there is no magical trash can that you can fish out removed files. 
Once they are gone, they are gone for good, so be careful. 


Fortunately there are some safety measures put into place, so the average joe can’t just remove a bunch of important files. 
Write-protected files will prompt you for confirmation before deleting them. 
If a directory is write-protected it will also not be easily removed. 


Now if you don’t care about any of that, you can absolutely remove a bunch of files. 


""rm -f file1""
-f or force option tells rm to remove all files, whether they are write protected or not, without prompting the user (as long as you have the appropriate permissions).


""rm -i file""
Adding the -i flag like many of the other commands, will give you a prompt on whether you want to actually remove the files or directories. 


""rm -r directory""
You can’t just rm a directory by default, you’ll need to add the -r flag (recursive) to remove all the files and any subdirectories it may have.


You can remove a directory with the rmdir command.
""rmdir directory""
        ";
 
    }

    public void lessonTwentyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
With all these files we have on the system it can get a little hectic trying to find a specific one. 
Well there’s a command we can use for that, find! 

""find /home -name puppies.jpg""


With find you’ll have to specify the directory you’ll be searching it, what you’re searching for. 
In this case we are trying to find a file by the name of puppies.jpg. 


You can specify what type of file you are trying to find. 

""find /home -type d -name MyFolder""

You can see that I set the type of file I’m trying to find as (d) for directory and I’m still searching by the name of MyFolder. 


One cool thing to note is that find doesn’t stop at the directory you are searching. 
It will look inside any subdirectories that directory may have as well.
        ";
     
    }

    public void lessonTwentyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Linux has some great built-in tools to help you how to use a command or check what flags are available for a command. 
One tool, help, is a built-in bash command that provides help for other bash commands (echo, logout, pwd, etc).

""help echo""

This will give you a description and the options you can use when you want to run echo. 
For other executable programs, it’s convention to have an option called --help or something similar. 

""echo --help""


Not all developers who ship out executables will conform to this standard, but it’s probably your best shot to find some help on a program.
        ";
     
    }

    public void lessonTwentySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Gee I wish some of these programs had a manual so we can see some more information about them. 
Well luckily they do! Aptly named man pages, you can see the manuals for a command with the man command. 

""man ls""


Man pages are manuals that are by default built into most Linux operating systems. 
They provide documentation about commands and other aspects of the system. 


Try it out on a few commands to get more information about them.

        ";
     
    }

    public void lessonTwentySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Whew, we’ve learned quite a bit of commands so far, if you are ever feeling doubtful about what a command does, you can use the whatis command. 
The whatis command provides a brief description of command line programs. 

""whatis cat""


The description gets sourced from the manual page of each command. 
If you ran whatis cat, you’d see there is a small blurb with a short description. 
        ";
 
    }

    public void lessonTwentyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Sometimes typing commands can get really repetitive, or if you need to type a long command many times, it’s best to have an alias you can use for that. 
To create an alias for a command you simply specify an alias name and set it to the command. 

""alias foobar='ls -la'""


Now instead of typing ls -la, you can type foobar and it will execute that command, pretty neat stuff. 
Keep in mind that this command won't save your alias after reboot, so you'll need to add a permanent alias in:

""~/.bashrc""

or similar files if you want to have it persist after reboot.


You can remove aliases with the unalias command: 

""unalias foobar""
        ";
 
    }

    public void lessonTwentyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonElevenButton.IsVisible=false;
        lessonTwelveButton.IsVisible=false;
        lessonThirteenButton.IsVisible=false;
        lessonFourteenButton.IsVisible=false;
        lessonFifteenButton.IsVisible=false;
        lessonSixteenButton.IsVisible=false;
        lessonSeventeenButton.IsVisible=false;
        lessonEighteenButton.IsVisible=false;
        lessonNineteenButton.IsVisible=false;
        lessonTwentyButton.IsVisible=false;
        lessonTwentyOneButton.IsVisible=false;
        lessonTwentyTwoButton.IsVisible=false;
        lessonTwentyThreeButton.IsVisible=false;
        lessonTwentyFourButton.IsVisible=false;
        lessonTwentyFiveButton.IsVisible=false;
        lessonTwentySixButton.IsVisible=false;
        lessonTwentySevenButton.IsVisible=false;
        lessonTwentyEightButton.IsVisible=false;
        lessonTwentyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Well, you sure did a good job getting through the basics. 
We’ve only scratched the surface, now that you’ve learned to crawl, in the next set of courses, I’m gonna teach how to walk. 


For now, you can pat yourself on the back and take a break. 
To exit from the shell, you can use the exit command

""exit""


Or the logout command:

""logout""


Or if you are working out of a terminal GUI, you can just close the terminal, see you in the next course!
        ";
 
    }

    //Text Fu Lessons

    public void lessonThirtyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
By now, we've become familiar with many commands and their output and that brings us to our next subject I/O (input/output) streams. 
Let's run the following command and we'll discuss how this works. 

""echo Hello World > peanuts.txt""


What just happened? Well check the directory where you ran that command and lo and behold you should see a file called peanuts.txt. 
Look inside that file and you should see the text Hello World. 
Lots of things just happened in one command so let's break it down. 


First let's break down the first part: 

""echo Hello World""

We know this prints out Hello World to the screen, but how? 
Processes use I/O streams to receive input and return output. 
By default the echo command takes the input (standard input or stdin) from the keyboard and returns the output (standard output or stdout) to the screen. 
So that's why when you type echo Hello World in your shell, you get Hello World on the screen. 
However, I/O redirection allows us to change this default behavior giving us greater file flexibility. 


Let's proceed to the next part of the command: 

"">""

The "">"" is a redirection operator that allows us the change where standard output goes. 
It allows us to send the output of echo Hello World to a file instead of the screen. 
If the file does not already exist it will create it for us. However, if it does exist it will overwrite it (you can add a shell flag to prevent this depending on what shell you are using).


And that's basically how stdout redirection works!


Well let's say I didn't want to overwrite my peanuts.txt, luckily there is a redirection operator for that as well, >>: 

""echo Hello World >> peanuts.txt""

This will append Hello World to the end of the peanuts.txt file, if the file doesn't already exist it will create it for us like it did with the "">"" redirector! 
        ";
 
    }

    public void lessonThirtyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In our previous lesson we learned that we have different stdout streams we can use, such as a file or the screen. 
Well there are also different standard input (stdin) streams we can use as well. 
We know that we have stdin from devices like the keyboard, but we can use files, output from other processes and the terminal as well, let's see an example. 


Let's use the peanuts.txt file in the previous lesson for this example, remember it had the text Hello World in it. 

""cat < peanuts.txt > banana.txt""

Just like we had "">"" for stdout redirection, we can use ""<"" for stdin redirection. 

Normally in the cat command, you send a file to it and that file becomes the stdin, in this case, we redirected peanuts.txt to be our stdin. 
Then the output of cat peanuts.txt which would be Hello World gets redirected to another file called banana.txt.
        ";
        
    }

    public void lessonThirtyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's try something a little different now, let's try to list the contents of a directory that doesn't exist on your system and redirect the output to the peanuts.txt file again.

""ls /fake/directory > peanuts.txt""


What you should see is: 
""ls: cannot access /fake/directory: No such file or directory""


Now you're probably thinking, shouldn't that message have been sent to the file? 
There is actually another I/O stream in play here called standard error (stderr). 
By default, stderr sends its output to the screen as well, it's a completely different stream than stdout. 
So you'll need to redirect its output a different way. 


Unfortunately the redirector is not as nice as using ""<"" or "">"" but it's pretty close. 
We will have to use file descriptors. A file descriptor is a non-negative number that is used to access a file or stream. 
We will go in depth about this later, but for now know that the file descriptor for stdin, stdout and stderr is 0, 1, and 2 respectively. 


So now if we want to redirect our stderr to the file we can do this: 
""ls /fake/directory 2> peanuts.txt""


You should see just the stderr messages in peanuts.txt. 

Now what if I wanted to see both stderr and stdout in the peanuts.txt file? 
It's possible to do this with file descriptors as well: 

""ls /fake/directory > peanuts.txt 2>&1""

This sends the results of ls /fake/directory to the peanuts.txt file and then it redirects stderr to the stdout via 2>&1. 
The order of operations here matters, ""2>&1"" sends stderr to whatever stdout is pointing to. 
In this case stdout is pointing to a file, so ""2>&1"" also sends stderr to a file. 
So if you open up that peanuts.txt file you should see both stderr and stdout. 
In our case, the above command only outputs stderr.

There is a shorter way to redirect both stdout and stderr to a file:

""ls /fake/directory &> peanuts.txt""

Now what if I don't want any of that cruft and want to get rid of stderr messages completely? 
Well you can also redirect output to a special file call /dev/null and it will discard any input.

""ls /fake/directory 2> /dev/null""
        ";
        
    }

    public void lessonThirtyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's get into some plumbing now, not really but kinda. Let's try a command: 

""ls -la /etc""

You should see a very long list of items, it's a little hard to read actually. 
Instead of redirecting this output to a file, wouldn't it be nice if we could just see the output in another command like less? 
Well we can!!!

""ls -la /etc | less""

The pipe operator |, represented by a vertical bar, allows us to get the stdout of a command and make that the stdin to another process. 
In this case, we took the stdout of ls -la /etc and then piped it to the less command. 
The pipe command is extremely useful and we will continue to use it for all eternity. 


Well what if I wanted to write the output of my command to two different streams? 
That's possible with the tee command: 

""ls | tee peanuts.txt""

You should see the output of ls on your screen and if you open up the peanuts.txt file you should see the same information!
        ";
        
    }

    public void lessonThirtyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Run the following command: 

""echo $HOME""

You should see the path to your home directory, mine looks like /home/pete. 


What about this command? 

""echo $USER""

You should see your username!


Where is this information coming from? 
It's coming from your environment variables. 
You can view these by typing:

""env""

This outputs a whole lot of information about the environment variables you currently have set. 
These variables contain useful information that the shell and other processes can use.

Here is a short example:

PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/bin
PWD=/home/user
USER=pete


One particularly important variable is the PATH Variable. 
You can access these variables by sticking a $ infront of the variable name like so:

$ echo $PATH
/usr/local/sbin:/usr/local/bin:/usr/sbin:/bin

This returns a list of paths separated by a colon that your system searches when it runs a command. 
Let's say you manually download and install a package from the internet and put it in to a non standard directory and want to run that command, you type $ coolcommand and the prompt says command not found. 
Well that's silly you are looking at the binary in a folder and know it exists. 
What is happening is that $PATH variable doesn't check that directory for this binary so it's throwing an error. 

Let's say you had tons of binaries you wanted to run out of that directory, you can just modify the PATH variable to include that directory in your PATH environment variable.
        ";
 
    }

    public void lessonThirtyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We're gonna learn a couple of useful commands that you can use to process text. 
Before we get started, let's create a file that we'll be working with. 
Copy and paste the following command, once you do that add a TAB in between lazy and dog (hold down Ctrl-v + TAB).

""echo 'The quick brown; fox jumps over the lazy  dog' > sample.txt""

First command we'll be learning about is the cut command. 
It extracts portions of text from a file. 


To extract contents by a list of characters: 

""cut -c 5 sample.txt""

This outputs the 5th character in each line of the file. 
In this case it is ""q"", note that the space also counts as a character. 


To extract the contents by a field, we'll need to do a little modification: 

""cut -f 2 sample.txt""

The -f or field flag cuts text based off of fields, by default it uses TABs as delimiters, so everything separated by a TAB is considered a field. 
You should see ""dog"" as your output.


You can combine the field flag with the delimiter flag to extract the contents by a custom delimiter: 

""cut -f 1 -d "";"" sample.txt""

This will change the TAB delimiter to a "";"" delimiter and since we are cutting the first field, the result should be ""The quick brown"".
        ";
 
    }

    public void lessonThirtySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The paste command is similar to the cat command, it merges lines together in a file. 
Let's create a new file with the following contents: 

sample2.txt
The
quick
brown
fox


Let's combine all these lines into one line: 

""paste -s sample2.txt""

The default delimiter for paste is TAB, so now there is one line with TABs separating each word.

Let's change this delimiter (-d) to something a little more readable: 

""paste -d ' ' -s sample2.txt""

Now everything should be on one line delimited by spaces.
        ";
 
    }

    public void lessonThirtySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's say we have a very long file, in fact we have many to choose from, go ahead and cat /var/log/syslog. 
You should see pages upon pages of text. 
What if I just wanted to see the first couple of lines in this text file? 
Well we can do that with the head command, by default the head command will show you the first 10 lines in a file.

""head /var/log/syslog""


You can also modify the line count to whatever you choose, let's say I wanted to see the first 15 lines instead. 

""head -n 15 /var/log/syslog""


The -n flag stands for number of lines. 
        ";
        
    }

    public void lessonThirtyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Similar to the head command, the tail command lets you see the last 10 lines of a file by default.

""tail /var/log/syslog""


Along with head you can change the number of lines you want to see.

""tail -n 10 /var/log/syslog""


Another great option you can use is the -f (follow) flag, this will follow the file as it grows. 
Give it a try and see what happens. 

""tail -f /var/log/syslog""


Your syslog file will be continually changing while you interact with your system and using tail -f you can see everything that is getting added to that file.
        ";
 
    }

    public void lessonThirtyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In our lesson on the cut command, we had our sample.txt file that contained a tab. 
Normally TABs would usually show a noticeable difference but some text files don't show that well enough. 
Having TABs in a text file may not be the desired spacing you want. 
To change your TABs to spaces, use the expand command. 

""expand sample.txt""


The command above will print output with each TAB converted into a group of spaces. 
To save this output in a file, use output redirection like below.

""expand sample.txt > result.txt""


Opposite to expand, we can convert back each group of spaces to a TAB with the unexpand command: 

""unexpand -a result.txt""
        ";
       
    }

    public void lessonFortyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The join command allows you to join multiple files together by a common field: 

Let's say I had two files that I wanted to join together:
file1.txt = 1 Jhon 2 Jane 3 Mary
file2.txt = 1 Doe 2 Doe 3 Sue

""join file1.txt file2.txt""
1 Jhon Doe 2 Jane Doe 3 Mary Sue

See how it joined together my files? 
They are joined together by the first field by default and the fields have to be identical. 
If they are not you can sort them, so in this case the files are joined via 1, 2, 3. 


How would we join the following files? 

file1.txt
John 1
Jane 2
Mary 3

file2.txt
1 Doe
2 Doe
3 Sue

To join this file you need to specify which fields you are joining. 
In this case we want field 2 on file1.txt and field 1 on file2.txt, so the command would look like this:

""join -1 2 -2 1 file1.txt file2.txt""
1 John Doe
2 Jane Doe
3 Mary Sue

-1 refers to file1.txt and -2 refers to file2.txt. 
Pretty neat. You can also split a file up into different files with the split command: 

""split somefile""

This will split it into different files, by default it will split them once they reach a 1000 line limit. 
The files are named x** by default.
        ";

    }

    public void lessonFortyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The sort command is useful for sorting lines.

file1.txt=
dog
cow
cat
elephant
bird

""sort file1.txt""
bird
cat
cow
dog
elephant


You can also do a reverse sort: 

""sort -r file1.txt""
elephant
dog
cow
cat
bird

And also sort via numerical value: 

""sort -n file1.txt""
bird
cat
cow
elephant
dog
        ";
    }

    public void lessonFortyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The tr (translate) command allows you to translate a set of characters into another set of characters. 
Let's try an example of translating all lower case characters to uppercase characters. 

""tr a-z A-Z""
hello
HELLO


As you can see we made the ranges of a-z into A-Z and all text we type that is lowercase gets uppercased. 
        ";
        
    }

    public void lessonFortyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The uniq (unique) command is another useful tool for parsing text.

Let's say you had a file with lots of duplicates:
reading.txt = book book paper paper article article magazine

And you wanted to remove the duplicates, well you can use the uniq command:
""uniq reading.txt"" = book paper article magazine

Let's get the count of how many occurrences of a line:

""uniq -c reading.txt""
2 book
2 paper
2 article
1 magazine

Let's just get unique values:

""uniq -u reading.txt"" = magazine

Let's just get duplicate values:

""uniq -d reading.txt"" = book paper article

Note: uniq does not detect duplicate lines unless they are adjacent. For eg:
Let's say you had a file with duplicates which are not adjacent:

reading.txt = book paper book paper article magazine article

""uniq reading.txt""
reading.txt = book paper book paper article magazine article

The result returned by uniq will contain all the entries unlike the very first
example.

To overcome this limitation of uniq we can use sort in combination with uniq:

""sort reading.txt | uniq""
article
book
magazine
paper
        ";
       
    }

    public void lessonFortyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The wc (word count) command shows the total count of words in a file. 

""wc /etc/passwd""
 96     265    5925 /etc/passwd


It display the number of lines, number of words and number of bytes, respectively.

To just see just the count of a certain field, use the -l, -w, or -c respectively. 

""wc -l /etc/passwd""
96

Another command you can use to check the count of lines on a file is the nl (number lines) command. 

file1.txt=
i
like
turtles

""nl file1.txt""
1. i
2. like
3. turtles
        ";
               
    }

    public void lessonFortyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonThirtyButton.IsVisible=false;
        lessonThirtyOneButton.IsVisible=false;
        lessonThirtyTwoButton.IsVisible=false;
        lessonThirtyThreeButton.IsVisible=false;
        lessonThirtyFourButton.IsVisible=false;
        lessonThirtyFiveButton.IsVisible=false;
        lessonThirtySixButton.IsVisible=false;
        lessonThirtySevenButton.IsVisible=false;
        lessonThirtyEightButton.IsVisible=false;
        lessonThirtyNineButton.IsVisible=false;
        lessonFortyButton.IsVisible=false;
        lessonFortyOneButton.IsVisible=false;
        lessonFortyTwoButton.IsVisible=false;
        lessonFortyThreeButton.IsVisible=false;
        lessonFortyFourButton.IsVisible=false;
        lessonFortyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The grep command is quite possibly the most common text processing command you will use. 
It allows you to search files for characters that match a certain pattern. 
What if you wanted to know if a file existed in a certain directory or if you wanted to see if a string was found in a file? 
You certainly wouldn't dig through every line of text, you would use grep!


Let's use our sample.txt file as an example: 
""grep fox sample.txt""


You should see that grep found fox in the sample.txt file. 


You can also grep patterns that are case insensitive with the -i flag: 
""grep -i somepattern somefile""


To get even more flexible with grep you can combine it with other commands with |.
""env | grep -i User""


As you can see grep is pretty versatile. 


You can even use regular expressions in your pattern: 
""ls /somedir | grep '.txt$'""

Should return all files ending with .txt in somedir.
        ";
    }


    //Advanced Text-Fu Lesssons

    public void lessonFortySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Regular expressions are a powerful tool to do pattern based selection. 
It uses special notations similar to those we've encountered already such as the * wildcard. 

We'll go through a couple of the most common regular expressions, these are almost universal with any programming language.

Well use this phrase as our test string:
sally sells seashells 
by the seashore

Beginning of a line with ""^""

^by
would match the line ""by the seashore""

End of a line with ""$""

seashore$
would match the line ""by the seashore""

Matching any single character with "".""

b.
would match by

Bracket notation with [] and ()

This can be a little tricky, brackets allow us to specify characters found within the bracket. 

d[iou]g
would match: dig, dog, dug

The previous anchor tag ^ when used in a bracket means anything except the characters within the bracket. 

d[^i]g
would match: dog and dug but not dig

Brackets can also use ranges to increase the amount of characters you want to use. 

d[a-c]g
will match patterns like dag, dbg, and dcg

Be careful though as brackets are case sensitive:
d[A-C]g
will match dAg, dBg and dCg but not dag, dbg and dcg. And those are some basic regular expressoins
        ";
    }

    public void lessonFortySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
If you get a couple of diehard Linux users in a room and ask them what is the best text editor to use, you'll hear a never ending banter about the godliness of either vim or emacs. 
Don't even try to bring up using a GUI editor if you value your life. 


Vim and emacs are popular text editors that are installed by default on most Linux distributions and they both have their pros and cons. 
If you want to get around your system like a ninja, you'll need to pick up one of these text editors to use. 
They are essentially coding, word document processing and basically all in one editors.
        ";
 
    }

    public void lessonFortyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Vim stands for vi (Improved) just like its name it stands for an improved version of the vi text editor command.


It's super lightweight, opening and editing a file with vim is quick and easy. 
It's also almost always available, if you booted up a random Linux distribution, chances are vim is installed by default. 


To fire up vim just type: ""vim""
        ";
        
    }

    public void lessonFortyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
To search for an expression just type the / key and then your search result while you are in a vim session. 
Once you hit enter, you can press ""n"" to go forward or ""N"" to go backward in your search results.


My pretty file is very pretty.

""/pretty""

will find the pretty words in the text file.


The ? search command will search the text file backwards, so in the previous example, the last pretty would come up first. 
My pretty file is very pretty.

""?pretty""

will find the pretty words in the text file.
        ";
    }

    public void lessonFiftyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now you may notice, the mouse is nowhere is use here. 
To navigate a text document in vim, use the following keys: 

h or the left arrow - will move you left one character
j or the up arrow - will move you up one line
k or the down arrow - will move you down one line
l or the right arrow - will move you right one character
        ";
    }

    public void lessonFiftyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"

        ";
        
    }

    public void lessonFiftyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
To edit text with vim, press ""i"" or ""a"" to enter in the ""INSERT"" mode.
In ""INSERT"" mode is where you use vim as your regular, day-to-day text editor(e.g MS Notepad)

The difference between ""i"" and ""a"" is that with ""i"", your cursor is behind the current position,
and with ""a"" your cursor is ahead the current position.


To go back to ""NORMAL"" mode (aka ""SHORTCUTS"" mode) press ESC.



(dev note: For some reason this lesson is not availabe in the linuxjourney repository, so i wrote this lesson this myself *.^)
        ";
     
    }

    public void lessonFiftyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"

Now that you've done your editing it's time to actually save and quit out of vim: 

:w - writes or saves the file
:q - quit out of vim
:wq - write and then quit
:q! - quit out of vim without saving the file
ZZ - equivalent of :wq, but one character faster

u - undo your last action
Ctrl-r - redo your last action

You may not think ZZ is necessary, but you'll eventually see that your fingers may tend to lean towards this rather than :wq.


Whew that was a lot of information to take about Vim. 
Now that you know some basic commands and navigation, you can start editing some text files. 
There are many more options you can use in vim to increase your ability to master this text editor, head on to Vim's online guide to take a look.
        ";
    }

    public void lessonFiftyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Emacs is for users who want an extremely powerful text editor, which may be an understatement because you essentially live in emacs. 
You can do all your code editing, file manipulation, etc all within emacs. 
It's a bit slower to load up and the learning curve is a bit steeper than vim, but if you want a powerful editor that is extremely extensible, this is the one for you.
When I say extensible, I literally mean you can write up scripts for emacs that extend its functionality.


To start emacs just use:

""emacs""


You should be greeted with the default welcome buffer.


Buffers in emacs is what your text resides in. 
So if you open up a file, a buffer is used to store that file's content. 
You can have multiple buffers open at the same time and you can easily switch between buffers.";
     
    }

    public void lessonFiftyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In a lot (if not all) of Emacs documentation, you will see the syntax C-[letter]. 
This just means hit the Ctrl-letter, but for shorthand purposes, we'll call Ctrl with C. 
If you see syntax such as M-[letter], that means use the Meta key, most commonly the Alt key.


Saving files:
C-x C-s - Save a file
C-x C-w - Save file as
C-x s - Save all


The save file options will prompt you if you want to save each file.


Opening a file:
C-x C-f


This will prompt you to type a filename to open. 
If you do not have a file that already exists, it will create a new file. 
You can load up a directory as well.
        ";
 
    }

    public void lessonFiftySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
To move around buffers (or files you're visiting) use the following commands:


Switch buffers:
C-x b - switch buffer
C-x right arrow - right-cycle through buffer
C-x left arrow - left-cycle through buffer


Close the buffer:
C-x k


Split the current buffer:
C-x 2


This allows you see multiple buffers on one screen. 
To move between these buffers use: C-x o

Set a single buffer as the current screen:
C-x 1


If you ever used a terminal multiplexer like screen and tmux, the buffer commands will feel very familiar.
        ";
        
    }

    public void lessonFiftySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Text Navigation:
C-up arrow : move up one paragraph
C-down arrow: move down one paragraph
C-left arrow: move one word left
C-right arrow: move one word right
M-> : move to the end of the buffer


With text navigation, your regular text buttons work as they should, home, end, page up, page down and the arrow keys, etc.


Cutting and Pasting:
To cut (kill) or paste (yank) in Emacs you'll need to be able to select text first. 
To select text, move your cursor to where you want to cut or paste and hit ""C-space key"" then you can use the navigation keys to select the text you want. 

Now you can do the cut and paste like so:
C-w : cut
C-y : yank
        ";
        
    }

    public void lessonFiftyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFortySixButton.IsVisible=false;
        lessonFortySevenButton.IsVisible=false;
        lessonFortyEightButton.IsVisible=false;
        lessonFortyNineButton.IsVisible=false;
        lessonFiftyButton.IsVisible=false;
        lessonFiftyOneButton.IsVisible=false;
        lessonFiftyTwoButton.IsVisible=false;
        lessonFiftyThreeButton.IsVisible=false;
        lessonFiftyFourButton.IsVisible=false;
        lessonFiftyFiveButton.IsVisible=false;
        lessonFiftySixButton.IsVisible=false;
        lessonFiftySevenButton.IsVisible=false;
        lessonFiftyEightButton.IsVisible=false;


        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
To close out of emacs:
C-x C-c


If you have any open buffers, it will ask you to save it before closing out of emacs.


Confused?
C-h C-h : help menu


Undo:
C-x u


As you can see Emacs has more moving parts, so the learning curve is a little steeper. 
In exchange though, you get a very powerful text editor.
        ";
            
    }

    //User Management Lessons

    public void lessonFiftyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFiftyNineButton.IsVisible=false;
        lessonSixtyButton.IsVisible=false;
        lessonSixtyOneButton.IsVisible=false;
        lessonSixtyTwoButton.IsVisible=false;
        lessonSixtyThreeButton.IsVisible=false;
        lessonSixtyFourButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
        @"
In any traditional operating system, there are users and groups. 
They exist solely for access and permissions. 
When running a process, it will run as the owner of that process whether that is Jane or Bob. 
File access and ownership is also permission dependent. 
You wouldn't want Jane to see Bob's documents and vice versa. 


Each user has their own home directory where their user specific files get stored, this is usually located in /home/username, 
but can vary in different distributions. 


The system uses user ids (UID) to manage users, usernames are the friendly way to associate users with identification, 
but the system identifies users by their UID. 
The system also uses groups to manage permissions, groups are just sets of users with permission set by that group, 
they are identified by the system with their group ID (GID).


In Linux, you'll have users in addition to the normal humans that use the system. 
Sometimes these users are system daemons that continuously run processes to keep the system functioning. 
One of the most important users is root or superuser, root is the most powerful user on the system, 
root can access any file and start and terminate any process. 
For that reason, it can be dangerous to operate as root all the time, you could potentially remove system critical files. 
Luckily, if root access is needed and a user has root access, they can run a command as root instead with the sudo command. 
The sudo command (superuser do) is used to run a command with root access, we'll go more in depth on how a user receives root access in a later lesson.


Go ahead and try to view a protected file like /etc/shadow:
""cat /etc/shadow""


Notice how you get a permission denied error, look at the permissions with: 
""ls -la /etc/shadow""
-rw-r----- 1 root shadow 1134 Dec 1 11:45 /etc/shadow


We haven't gone through permissions yet, but what's happening here is that root is the owner of the file and you'll need root access or be part of the shadow group to read the contents. 
Now run the command with sudo:

""sudo cat /etc/shadow""

Now you'll be able to see the contents of the file!
        ";

    }

    public void lessonSixtyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFiftyNineButton.IsVisible=false;
        lessonSixtyButton.IsVisible=false;
        lessonSixtyOneButton.IsVisible=false;
        lessonSixtyTwoButton.IsVisible=false;
        lessonSixtyThreeButton.IsVisible=false;
        lessonSixtyFourButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
We've looked at one way to get superuser access using the sudo command. 
You can also run commands as the superuser with the su command. 
This command will ""substitute users"" and open a root shell if no username is specified. 
You can use this command to substitute to any user as long as you know the password. 

""su""


There are some downsides to using this method: it's much easier to make a critical mistake running everything in root, 
you won't have records of the commands you use to change system configurations, etc. 
Basically, if you need to run commands as the superuser, just stick to sudo.


Now that you know what commands to run as the superuser, the question is how do you know who has access to do that? 
The system doesn't let every single Joe Schmoe run commands as the superuser, so how does it know? 
There is a file called the /etc/sudoers file, this file lists users who can run sudo. 
You can edit this file with the ""visudo"" command.
       ";
 
    }

    public void lessonSixtyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFiftyNineButton.IsVisible=false;
        lessonSixtyButton.IsVisible=false;
        lessonSixtyOneButton.IsVisible=false;
        lessonSixtyTwoButton.IsVisible=false;
        lessonSixtyThreeButton.IsVisible=false;
        lessonSixtyFourButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Remember that usernames aren't really identifications for users. 
The system uses a user ID (UID) to identify a user. 
To find out what users are mapped to what ID, look at the /etc/passwd file. 

""cat /etc/passwd""


This file shows you a list of users and detailed information about them. 
For example, the first line in this file most likely looks like this:

""root:x:0:0:root:/root:/bin/bash""


Each line displays user information for one user, most commonly you'll see the root user as the first line. 
There are many fields separated by colons that tell you additional information about the user, let's look at them all:
1- Username

2- User's password - the password is not really stored in this file, it's usually stored in the /etc/shadow file. 
We'll discuss more in the next lesson about /etc/shadow, but for now, know that it contains encrypted user passwords. 
You can see many different symbols that are in this field, if you see an ""x"" that means the password is stored in the /etc/shadow file, 
a ""*"" means the user doesn't have login access and if there is a blank field that means the user doesn't have a password.

3- The user ID - as you can see root has the UID of 0

4- The group ID

5- GECOS field - This is used to generally leave comments about the user or account such as their real name or phone number, it is comma delimited.

6- User's home directory

7- User's shell - you'll probably see a lot of user's defaulting to bash for their shell


Normally in a user's setting page, you would expect you see just human users. 
However, you'll notice /etc/passwd contains other users. 
Remember that users are really only on the system to run processes with different permissions. 
Sometimes we want to run processes with pre-determined permissions. 
For example, the daemon user is used for daemon processes.


Also should note that you can edit the /etc/passwd file by hand if you want to add users and modify information with the ""vipw"" tool, 
however things like these are best left to the tools we will discuss in a later lesson such as useradd and userdel.
       ";
       
    }

    public void lessonSixtyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFiftyNineButton.IsVisible=false;
        lessonSixtyButton.IsVisible=false;
        lessonSixtyOneButton.IsVisible=false;
        lessonSixtyTwoButton.IsVisible=false;
        lessonSixtyThreeButton.IsVisible=false;
        lessonSixtyFourButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
The /etc/shadow file is used to store information about user authentication. 
It requires superuser read permissions. 
""sudo cat /etc/shadow""
root:MyEPTEa$6Nonsense:15000:0:99999:7:::


You'll notice that it looks very similar to the contents of /etc/passwd, however in the password field you'll see an encrypted password. 
The fields are separated by colons as followed:
1- Username

2- Encrypted password

3- Date of last password changed - expressed as the number of days since Jan 1, 1970. If there is a 0 that means the user should change their password the next time they login

4- Minimum password age - Days that a user will have to wait before being able to change their password again

5- Maximum password age - Maximum number of days before a user has to change their password

6- Password warning period - Number of days before a password is going to expire

7- Password inactivity period - Number of days after a password has expired to allow login with their password

8- Account expiration date - date that user will not be able to login

9- Reserved field for future use


In most distributions today, user authentication doesn't rely on just the /etc/shadow file, 
there are other mechanisms in place such as PAM (Pluggable Authentication Modules) that replace authentication.
       ";
     
    }

    public void lessonSixtyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFiftyNineButton.IsVisible=false;
        lessonSixtyButton.IsVisible=false;
        lessonSixtyOneButton.IsVisible=false;
        lessonSixtyTwoButton.IsVisible=false;
        lessonSixtyThreeButton.IsVisible=false;
        lessonSixtyFourButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Another file that is used in user management is the /etc/group file. 
This file allows for different groups with different permissions. 

""cat /etc/group""
root:*:0:pete


Very similar to the /etc/password field, the /etc/group fields are as follows:
1- Group name

2- Group password - there isn't a need to set a group password, using an elevated privilege like sudo is standard. 
A ""*"" will be put in place as the default value.

3- Group ID (GID)

4- List of users - you can manually specify users you want in a specific group
       ";
       
    }

    public void lessonSixtyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonFiftyNineButton.IsVisible=false;
        lessonSixtyButton.IsVisible=false;
        lessonSixtyOneButton.IsVisible=false;
        lessonSixtyTwoButton.IsVisible=false;
        lessonSixtyThreeButton.IsVisible=false;
        lessonSixtyFourButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Most enterprise environments are using management systems to manage users, accounts and passwords. 
However, on a single machine computer there are useful commands to run to manage users.


Adding Users:
You can use the ""adduser"" or the ""useradd"" command. 
The adduser command contains more helpful features such as making a home directory and more. 
There are configuration files for adding new users that can be customized depending on what you want to allocate to a default user. 

""sudo useradd bob""

You'll see that the above command creates an entry in /etc/passwd for bob, sets up default groups and adds an entry to the /etc/shadow file.


Removing Users:
To remove a user, you can use the ""userdel"" command.

""sudo userdel bob""

This basically does its best to undo the file changes by useradd.


Changing Passwords:
""passwd bob""

This will allow you to change the password of yourself or another user (if you are root).
       ";
       
    }

    // Permissions Lessons

    public void lessonSixtyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
As we learned previously, files have different permissions or file modes. 
Let's look at an example:

""ls -l Desktop/""
drwxr-xr-x 2 pete penguins 4096 Dec 1 11:45 .


There are four parts to a file's permissions. 
The first part is the filetype, which is denoted by the first character in the permissions, 
in our case since we are looking at a directory it shows ""d"" for the filetype. 
Most commonly you will see a <b>-</b> for a regular file. 


The next three parts of the file mode are the actual permissions. 
The permissions are grouped into 3 bits each. 
The first 3 bits are user permissions, then group permissions and then other permissions. 
I've added the pipe to make it easier to differentiate.

""d | rwx | r-x | r-x""


Each character represent a different permission: 
r: readable
w: writable
x: executable (basically an executable program)
-: empty

So in the above example, we see that the user pete has read, write and execute permissions on the file. 
The group penguins has read and execute permissions. 
And finally, the other users (everyone else) has read and execute permissions. 
       ";

    }

    public void lessonSixtySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Changing permissions can easily be done with the ""chmod"" command. 
First, pick which permission set you want to change, user, group or other. 
You can add or remove permissions with a ""+"" or ""-"", let's look at some examples.

Adding permission bit on a file:
""chmod u+x myfile""

The above command reads like this: change permission on myfile by adding executable permission bit on the user set. 
So now the user has executable permission on this file!


Removing permission bit on a file:
""chmod u-x myfile""


Adding multiple permission bits on a file:
""chmod ug+w""


There is another way to change permissions using numerical format. This method allows you to change permissions all at once. 
Instead of using r, w, or x to represent permissions, you'll use a numerical representation for a single permission set. 
So no need to specify the group with g or the user with u.


The numerical representations are seen below:

4: read permission
2: write permission
1: execute permission


Let's look at an example: 
""chmod 755 myfile""

Can you guess what permissions we are giving this file? 
Let's break this down, so now 755 covers the permissions for all sets. 
The first number (7) represents user permissions, the second number (5) represents group permissions and the last 5 represents other permissions. 

Wait a minute, 7 and 5 weren't listed above, where are we getting these numbers? 
Remember we are combining all the permissions into one number now, so you'll have to get some math involved.


7 = 4 + 2 + 1, so 7 is the user permissions and it has read, write and execute permissions
5 = 4 + 1, the group has read and execute permissions
5 = 4 +1, and all other users have read and execute permissions

One thing to note: it's not a great idea to be changing permissions nilly willy,  you could potentially expose a sensitive file for everyone to modify,
however many times you legitimately want to change permissions, just take precaution when using the chmod command.
       ";
     
    }

    public void lessonSixtySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
In addition to modifying permissions on files, you can also modify the group and user ownership of the file as well. 

Modify user ownership:
""sudo chown patty myfile""

This command will set the owner of myfile to patty.


Modify group ownership:
""sudo chgrp whales myfile""

This command will set the group of myfile to whales.


Modify both user and group ownership at the same time:
If you add a colon and groupname after the user you can set both the user and group at the same time.

""sudo chown patty:whales myfile""
       ";
 
    }

    public void lessonSixtyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Every file that gets created comes with a default set of permissions. 
If you ever wanted to change that default set of permissions, you can do so with the umask command. 
This command takes the 3 bit permission set we see in numerical permissions. 


Instead of adding these permissions though, umask TAKES AWAY these permissions. 


""umask 021""

In the above example, we are stating that we want the default permissions of new files to allow users access to everything, 
but for groups we want to take away their write permission and for others we want to take away their executable permission. 
The default umask on most distributions is 022, meaning all user access, but no write access for group and other users.


When you run the umask command it will give that default set of permissions on any new file you make. 
However, if you want it to persist you'll have to modify your startup file (.profile), but we'll discuss that in a later lesson.
       ";
     
    }

    public void lessonSixtyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
There are many cases in which normal users need elevated access to do stuff. 
The system administrator can't always be there to enter in a root password every time a user needed access to a protected file, so there are special file permission bits to allow this behavior. 
The Set User ID (SUID) allows a user to run a program as the owner of the program file rather than as themselves.

Let's look at an example: 
Let's say I want to change my password, simple right? I just use the passwd command:
""passwd""


What is the password command doing? It's modifying a couple of files, but most importantly it's modifying the /etc/shadow file. 
Let's look at that file for a second: 
""ls -l /etc/shadow""
-rw-r----- 1 root shadow 1134 Dec 1 11:45 /etc/shadow


Oh wait a minute here, this file is owned by root? 
How is it possible that we are able to modify a file owned by root? 


Let's look at another permission set, this time of the command we ran: 
""ls -l /usr/bin/passwd""

-rwsr-xr-x 1 root root 47032 Dec 1 11:45 /usr/bin/passwd


You'll notice a new permission bit here ""s"". This permission bit is the SUID, when a file has this permission set,
it allows the users who launched the program to get the file owner's permission as well as execution permission, in this case root. So essentially while a user is running the password command, 
they are running as root.

That's why we are able to access a protected file like ""/etc/shadow"" when we run the passwd command. 
Now if you removed that bit, you would see that you will not be able to modify ""/etc/shadow"" and therefore change your password. 

Modifying SUID:
Just like regular permissions there are two ways to modify SUID permissions. 

Symbolic way:
""sudo chmod u+s myfile""

Numerical way:
""sudo chmod 4755 myfile""

As you can see the SUID is denoted by a 4 and pre-pended to the permission set. 
You may see the SUID denoted as a capital ""S"" this means that it still does the same thing, but it does not have execute permissions.
       ";
              
    }

    public void lessonSeventyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Similar to the set user ID permission bit, there is a set group ID (SGID) permission bit. 
This bit allows a program to run as if it was a member of that group. 


Let's look at one example: 
""ls -l /usr/bin/wall""
-rwxr-sr-x 1 root tty 19024 Dec 14 11:45 /usr/bin/wall


We can see now that the permission bit is in the group permission set. 


Modifying SGID:
""sudo chmod g+s myfile""
""sudo chmod 2555 myfile""


The numerical representation for SGID is 2.
       ";
       
    }

    public void lessonSeventyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
Let's segway into process permissions for a bit, remember how I told you that when you run the passwd command with the SUID permission bit enabled you will run the program as root? 
That is true, however does that mean since you are temporarily root you can modify other user's passwords? Nope fortunately not!


This is because of the many UIDs that Linux implements. 
There are three UIDS associated with every process:


When you launch a process, it runs with the same permissions as the user or group that ran it, 
this is known as an ""effective user ID"". This UID is used to grant access rights to a process. 
So naturally if Bob ran the touch command, the process would run as him and any files he created would be under his ownership.


There is another UID, called the ""real user ID"" this is the ID of the user that launched the process. 
These are used to track down who the user who launched the process is.


One last UID is the ""saved user ID"", this allows a process to switch between the effective UID and real UID, vice versa. 
This is useful because we don't want our process to run with elevated privileges all the time, it's just good practice to use special privileges at specific times. 


Now let's piece these all together by looking at the passwd command once more. 
When running the passwd command, your effective UID is your user ID, let's say its 500 for now. 
Oh but wait, remember the passwd command has the SUID permission enabled. 
So when you run it, your effective UID is now 0 (0 is the UID of root). Now this program can access files as root.


Let's say you get a little taste of power and you want to modify Sally's password, Sally has a UID of 600. 
Well you'll be out of luck, fortunately the process also has your real UID in this case 500. 
It knows that your UID is 500 and therefore you can't modify the password of UID of 600. (This of course is always bypassed if you are a superuser on a machine and can control and change everything).


Since you ran passwd, it will start the process off using your real UID, and it will save the UID of the owner of the file (effective UID), 
so you can switch between the two. No need to modify all files with root access if it's not required. 


Most of the time the real UID and the effective UID are the same, but in such cases as the passwd command they will change.
       ";
 
    }

    public void lessonSeventyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=false;
        lessonSixtySixButton.IsVisible=false;
        lessonSixtySevenButton.IsVisible=false;
        lessonSixtyEightButton.IsVisible=false;
        lessonSixtyNineButton.IsVisible=false;
        lessonSeventyButton.IsVisible=false;
        lessonSeventyOneButton.IsVisible=false;
        lessonSeventyTwoButton.IsVisible=false;

       lessonContent.IsVisible=true;
       lessonContent.Content=
       @"
One last special permission bit I want to talk about is the sticky bit. 


This permission bit, ""sticks a file/directory"" this means that only the owner or the root user can delete or modify the file. 
This is very useful for shared directories. Take a look at the example below:

""ls -ld /tmp""
drwxrwxrwxt 6 root root 4096 Dec 15 11:45 /tmp


You'll see a special permission bit at the end here ""t"", this means everyone can add files, write files, modify files in the /tmp directory, 
but only root can delete the /tmp directory. 


Modify sticky bit:
""sudo chmod +t mydir""
""sudo chmod 1755 mydir""


The numerical representation for the sticky bit is ""1""
       ";
     
    }

    //Process Lessons

    public void lessonSeventyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Processes are the programs that are running on your machine. They are managed by the kernel and each process has an ID associated with it called the ""process ID (PID)."" 
This PID is assigned in the order that processes are created. 

Go ahead and run the ps command to see a list of running processes:
""ps""
PID        TTY     STAT   TIME          CMD
41230    pts/4    Ss        00:00:00     bash
51224    pts/4    R+        00:00:00     ps

This shows you a quick snapshot of the current processes:

PID: Process ID
TTY: Controlling terminal associated with the process (we'll go in detail about this later)
STAT: Process status code
TIME: Total CPU usage time
CMD: Name of executable/command

If you look at the man page for ps you'll see that there are lots of command options you can pass, 
they will vary depending on what options you want to use - BSD, GNU or Unix. 
In my opinion the BSD style is more popular to use, so we're gonna go with that. 
If you are curious the difference between the styles is the amount of dashes you use and the flags.

""ps aux""

1- The ""a"" displays all processes running, including the ones being ran by other users. 
2- The ""u"" shows more details about the processes. 
3- And finally the ""x"" lists all processes that don't have a TTY associated with it, these programs will show a ? in the TTY field,  they are most common in daemon processes that launch as part of the system startup.


You'll notice you're seeing a lot more fields now, no need to memorize them all, in a later course on advanced processes, we'll go over some of these again:

USER: The effective user (the one whose access we are using)
PID: Process ID
%CPU: CPU time used divided by the time the process has been running
%MEM: Ratio of the process's resident set size to the physical memory on the machine
VSZ: Virtual memory usage of the entire process
RSS: Resident set size, the non-swapped physical memory that a task has used
TTY: Controlling terminal associated with the process
STAT: Process status code
START: Start time of the process
TIME: Total CPU usage time
COMMAND: Name of executable/command

The ps command can get a little messy to look at, for now the fields we will look at the most are PID, STAT and COMMAND. 

Another very useful command is the ""top"" command, top gives you real time information about the processes running on your system instead of a snapshot. 
By default you'll get a refresh every 10 seconds. Top is an extremely useful tool to see what processes are taking up a lot of your resources. 
Go ahead and launch it by typing: ""top""
        ";
 
    }

    public void lessonSeventyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We discussed how there is a TTY field in the ps output. 
The TTY is the terminal that executed the command.


There are two types of terminals, ""regular terminal devices"" and ""pseudoterminal devices"". 
A regular terminal device is a native terminal device that you can type into and send output to your system, 
this sounds like the terminal application you've been launching to get to your shell, but it's not. 


We're gonna segue so you can see this action, go ahead and type Ctrl-Alt-F1 to get into TTY1 (the first virtual console), 
you'll notice how you don't have anything except the terminal, no graphics, etc. 
This is considered a ""regular terminal device"", you can exit this with Ctrl-Alt-F7. 


A pseudoterminal is what you've been used to working in, 
they emulate terminals with the shell terminal window and are denoted by PTS . 
If you look at ps again, you'll see your shell process under pts/*.


Ok, now circling back to the controlling terminal, processes are usually bound to a controlling terminal. 
For example, if you were running a program on your shell window such as find and you closed the window, your process would also go with it. 


There are processes such as daemon processes, which are special processes that are essentially keeping the system running. 
They often start at system boot and usually get terminated when the system is shutdown. 
They run in the background and since we don't want these special processes to get terminated they are not bound to a controlling terminal. 
In the ps output, the TTY is listed as a ""?"" meaning it does not have a controlling terminal.
        ";
     
    }

    public void lessonSeventyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before we get into more practical applications of processes, we have to first understand what they are and how they work. 
This part can get confusing since we are diving into the nitty gritty, 
so feel free to come back to this lesson if you don't want to learn about it now. 


A process like we said before is a running program on the system, 
more precisely it's the system allocating memory, CPU, I/O to make the program run. 
A process is an instance of a running program, 
go ahead and open 3 terminal windows, in two windows, run the ""cat"" command without passing any options (the cat process will stay open as a process because it expects stdin). 
Now in the third window run: ""ps aux | grep cat"". You'll see that there are two processes for cat, even though they are calling the same program.


The kernel is in charge of processes, when we run a program the kernel loads up the code of the program in memory, 
determines and allocates resources and then keeps tabs on each process, it knows: 

1- The status of the process
2- The resources the process is using and receives
3- The process owner
4- Signal handling (more on that later)
5- And basically everything else


All processes are trying to get a taste of that sweet resource pie, it's the kernel's job to make sure that processes get the right amount of resources depending on process demands. 
When a process ends, the resources it used are now freed up for other processes.
        ";
 
    }

    public void lessonSeventySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Again this lesson and the next are purely information to let you see what's under the hood, 
feel free to circle back to this once you've worked with processes a bit more.


When a new process is created, an existing process basically clones itself using something called the fork system call (system calls will be discussed very far into the future). 
The fork system call creates a mostly identical child process, this child process takes on a new process ID (PID), 
and the original process becomes its parent process and has something called a parent process ID (PPID). 

Afterwards, the child process can either continue to use the same program its parent was using before or more often use the execve system call to launch up a new program. 
This system call destroys the memory management that the kernel put into place for that process and sets up new ones for the new program. 


We can see this in action:
""ps l""

The l option gives us a ""long format"" or even more detailed view of our running processes. 
You'll see a column labelled ""PPID"", this is the parent ID. 
Now look at your terminal, you'll see a process running that is your shell, so on my system I have a process running bash. 
Now remember when you ran the ps l command, you were running it from the process that was running bash. 
Now you'll see that the ""PID"" of the bash shell is the ""PPID"" of the ""ps l"" command.


So if every process has to have a parent and they are just forks of each other, there must be a mother of all processes right? 
You are correct, when the system boots up, the kernels creates a process called ""init"", it has a PID of 1. 
The init process can't be terminated unless the system shuts down. 
It runs with root privileges and runs many processes that keep the system running. 

We will take a closer look at init in the system bootup course, for now just know it is the process that spawns all other processes.
        ";
 
    }

    public void lessonSeventySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now that we know what goes on when a process gets created, what is happening when we don't need it anymore? 
Be forewarned, sometimes Linux can get a little dark...


A process can exit using the _exit system call, this will free up the resources that process was using for reallocation. 
So when a process is ready to terminate, it lets the kernel know why it's terminating with something called a termination status. 
Most commonly a status of 0 means that the process succeeded. 

However, that's not enough to completely terminate a process. 
The parent process has to acknowledge the termination of the child process by using the wait system call and what this does is it checks the termination status of the child process. 
I know it's gruesome to think about, but the wait call is a necessity, after all what parent wouldn't want to know how their child died?


There is another way to terminate a process and that involves using signals, which we will discuss soon.


Orphan Processes:
When a parent process dies before a child process, the kernel knows that it's not going to get a wait call, 
so instead it makes these processes ""orphans"" and puts them under the care of init (remember mother of all processes). 
Init will eventually perform the wait system call for these orphans so they can die. 


Zombie Processes:
What happens when a child terminates and the parent process hasn't called wait yet? 
We still want to be able to see how a child process terminated, so even though the child process finished, 
the kernel turns the child process into a zombie process. 

The resources the child process used are still freed up for other processes, however there is still an entry in the process table for this zombie. 
Zombie processes also cannot be killed, since they are technically ""dead"", so you can't use signals to kill them. 

Eventually if the parent process calls the wait system call, the zombie will disappear, this is known as ""reaping"". 
If the parent doesn't perform a wait call, init will adopt the zombie and automatically perform wait and remove the zombie. 
It can be a bad thing to have too many zombie processes, since they take up space on the process table, if it fills up it will prevent other processes from running.
        ";
        
    }

    public void lessonSeventyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
A signal is a notification to a process that something has happened.

Why we have signals:
They are software interrupts and they have lots of uses:

1- A user can type one of the special terminal characters (Ctrl-C) or (Ctrl-Z) to kill, interrupt or suspend processes
2- Hardware issues can occur and the kernel wants to notify the process
3- Software issues can occur and the kernel wants to notify the process
4- They are basically ways processes can communicate


Signal process:
When a signal is generated by some event, it's then delivered to a process, it's considered in a pending state until it's delivered. 
When the process is ran, the signal will be delivered. However, processes have signal masks and they can set signal delivery to be blocked if specified. 
When a signal is delivered, a process can do a multitude of things: 

1- Ignore the signal
2- ""Catch"" the signal and perform a specific handler routine
3- Process can be terminated, as opposed to the normal exit system call
4- Block the signal, depending on the signal mask


Common signals:

Each signal is defined by integers with symbolic names that are in the form of SIGxxx. 
Some of the most common signals are: 

SIGHUP or HUP or 1: Hangup
SIGINT or INT or 2: Interrupt
SIGKILL or KILL or 9: Kill
SIGSEGV or SEGV or 11: Segmentation fault
SIGTERM or TERM or 15: Software termination
SIGSTOP or STOP: Stop

Numbers can vary with signals so they are usually referred by their names.

Some signals are unblockable, one example is the SIGKILL signal. 
The KILL signal destroys the process.
        ";
     
    }

    public void lessonSeventyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
You can send signals that terminate processes, such a command is aptly named the kill command. 
""kill 12445""


The ""12445"" is the PID of the process you want to kill. 
By default it sends a TERM signal. The SIGTERM signal is sent to a process to request its termination by allowing it to cleanly release its resources and saving its state. 


You can also specify a signal with the kill command: 

""kill -9 12445""

This will run the SIGKILL signal and kill the process. 


Differences between SIGHUP, SIGINT, SIGTERM, SIGKILL, SIGSTOP?
These signals all sound reasonably similar, but they do have their differences. 

SIGHUP - Hangup, sent to a process when the controlling terminal is closed. 
For example, if you closed a terminal window that had a process running in it, you would get a SIGHUP signal. So basically you've been hung up on

SIGINT - Is an interrupt signal, so you can use Ctrl-C and the system will try to gracefully kill the process

SIGTERM - Kill the process, but allow it to do some cleanup first

SIGKILL - Kill the process, kill it with fire, doesn't do any cleanup

SIGSTOP - Stop/suspend a process
        ";
    }

    public void lessonEightyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
When you run multiple things on your computer, like perhaps Chrome, Microsoft Word or Photoshop at the same time, 
it may seem like these processes are running at the same time, but that isn't quite true. 


Processes use the CPU for a small amount of time called a time slice. 
Then they pause for milliseconds and another process gets a little time slice. 

By default, process scheduling happens in this round-robin fashion. 
Every process gets enough time slices until it's finished processing. 
The kernel handles all of these switching of processes and it does a pretty good job at it most of the time.


Processes aren't able to decide when and how long they get CPU time, if all processes behaved normally they would each (roughly) get an equal amount of CPU time. 
However, there is a way to influence the kernel's process scheduling algorithm with a nice value. 
Niceness is a pretty weird name, but what it means is that processes have a number to determine their priority for the CPU. 
A high number means the process is nice and has a lower priority for the CPU and a low or negative number means the process is not very nice and it wants to get as much of the CPU as possible. 


Type ""top"" in your terminal!
You can see a column for ""NI"" right now, that is the niceness level of a process.


To change the niceness level you can use the nice and renice commands:
""nice -n 5 apt upgrade""


The nice command is used to set priority for a new process. 
The renice command is used to set priority on an existing process. 

""renice 10 -p 3245""
        ";
        
    }

    public void lessonEightyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's take a look at the ps aux command again:
""ps aux""


In the STAT column, you'll see lots of values. 
A linux process can be in a number of different states. 
The most common state codes you'll see are described below:


1- R: running or runnable, it is just waiting for the CPU to process it

2- S: Interruptible sleep, waiting for an event to complete, such as input from the terminal

3- D: Uninterruptible sleep, processes that cannot be killed or interrupted with a signal, 
usually to make them go away you have to reboot or fix the issue

4- Z: Zombie, we discussed in a previous lesson that zombies are terminated processes that are waiting to have their statuses collected

5- T: Stopped, a process that has been suspended/stopped
        ";
     
    }
    
    public void lessonEightyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Remember everything in Linux is a file, even processes. 
Process information is stored in a special filesystem known as the ""/proc filesystem"".

""ls /proc""


You should see multiple values in here, there are sub-directories for every PID. 
If you looked at a PID in the ps output, you would be able to find it in the ""/proc"" directory.


Go ahead and enter one of the processes and look at that file:

""cat /proc/12345/status""

You should see process state information and well as more detailed information. 


The ""/proc"" directory is how the kernel is views the system, 
so there is a lot more information here than what you would see in ps.
        ";
 
    }

    public void lessonEightyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=false;
        lessonSeventyFourButton.IsVisible=false;
        lessonSeventyFiveButton.IsVisible=false;
        lessonSeventySixButton.IsVisible=false;
        lessonSeventySevenButton.IsVisible=false;
        lessonSeventyEightButton.IsVisible=false;
        lessonSeventyNineButton.IsVisible=false;
        lessonEightyButton.IsVisible=false;
        lessonEightyOneButton.IsVisible=false;
        lessonEigthyTwoButton.IsVisible=false;
        lessonEightyThreeButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's say you're working on a single terminal window and you're running a command that is taking forever. 
You can't interact with the shell until it is complete, however we want to keep working on our machines, so we need that shell open. 
Fortunately we can control how our processes run with jobs: 

Sending a job to the background:
Appending an ampersand (&) to the command will run it in the background so you can still use your shell. Let's see an example:

""sleep 1000 &""
""sleep 1001 &""
""sleep 1002 &""

View all background jobs:
""jobs""
Now you can view the jobs you just sent to the background.
[1]    Running     sleep 1000 &
[2]-   Running     sleep 1001 &
[3]+   Running     sleep 1002 &

This will show you the job id in the first column, then the status and the command that was run. 
The ""+"" next to the job ID means that it is the most recent background job that started. 
The job with the ""-"" is the second most recent command.


Sending a job to the background on existing job:
If you already ran a job and want to send it to the background, you don't have to terminate it and start over again. 
First suspend the job with Ctrl-Z, then run the ""bg"" command to send it to the background.

pete@icebox ~ $ sleep 1003
^Z
[4]+    Stopped     sleep 1003

pete@icebox ~ $ bg
[4]+    sleep 1003 &

pete@icebox ~ $ jobs

[1]    Running     sleep 1000 &
[2]    Running     sleep 1001 &
[3]-   Running     sleep 1002 &
[4]+   Running     sleep 1003 &


Moving a job from the background to the foreground:
To move a job out of the background just specify the job ID you want. If you run fg without any options, it will bring back the most recent background job (the job with the + sign next to it)
""fg %1""

Kill background jobs: Similar to moving jobs out of the background, you can use the same form to kill the processes by using their Job ID.
""kill %1""
        ";
        
    }

    //Packages Lessons

    public void lessonEightyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Your system is comprised of many packages such as internet browsers, text editors, media players, etc. 
These packages are managed via package managers, which install and maintain the software on your system. 
Not all packages are installed through package managers though, you can commonly install packages directly from their source code (we'll get to that soon). 

However the majority of the time you will use a package manager to install software, the most common variety of packages are Debian (.deb) and Red Hat (.rpm). 
Debian style packages are used in distributions such as Debian, Ubuntu, LinuxMint, etc. 
Red Hat style packages are seen in Red Hat Enterprise Linux, Fedora, CentOS, etc.


What are packages? You may know them as Chrome, Photoshop, etc and they are, but what they really are just lots and lots of files that have been compiled into one. 
The people (or sometimes a single person) that write this software are known as ""upstream providers"", they compile their code and write up how to get it installed. 
These upstream providers work on getting out new software and update existing software. 

When they are ready to release it to the world, they send their package to ""package maintainers"", who handle getting this piece of software in the hands of the users. 
These package maintainers review, manage and distribute this software in the form of packages.
        ";
 
    }

    public void lessonEightyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
How do packages that get uploaded to the internet somehow end up on our computers? 
Do you go to the download page of each package you want and click download and install? 
Well, actually you can do that, but there is something better called package repositories. 

Repositories are just a central storage location for packages. 
There are tons of repositories that hold lots of packages and best of all they are all found on the internet, no silly installation disks. 
Your machine doesn't know where to look for these repositories unless you explicitly tell it where to look.


For example, let's say I want WackyWidgets Software on my machine. 
Well WackyWidgets manages their own repositories for their widget packages, inside this repository are 10 packages, the CoolWidget package, the SuperWidget package, etc. 
WackyWidgets hosts this repository at a source link called: http://download.widgets/linux/deb/


Now instead of going to their website to download the package directly, you can tell your machine to find WackyWidgets software from the source link. 


Your distribution already comes with pre-approved sources to get packages from and this is how it installs all the base packages you see on your system. 
On a Debian system, this sources file is the ""/etc/apt/sources.list"" file. 
Your machine will know to look there and check for any source repositories you added. 
        ";
 
    }

    public void lessonEightySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before we get into package installation and the different managers, we need to discuss archiving and compressing files, 
because you will most likely encounter these when you hunt for software on the internet. 

You probably already know what a file archive is, you've most likely encountered file types such as .rar and .zip. 
These are an archive of files, they contain many files inside of them, but they come in this very neat single file known as an archive.

Compressing files with gzip:
gzip is program used to compress files in Linux, they end in a .gz extension. 

To compress a file down:
""gzip mycoolfile""

To decompress the file:
""gunzip mycoolfile.gz""


Creating archives with tar:
Unfortunately, gzip can't add multiple files into one archive for us. Luckily we have the tar program which does. 
When you create an archive using tar, it will have a .tar extension. 

""tar cvf mytarfile.tar mycoolfile1 mycoolfile 2""

1- c - create
2- v - tell the program to be verbose and let us see what it's doing
3- f - the filename of the tar file has to come after this option, if you are creating a tar file you'll have to come up with a name

Unpacking archives with tar:
To extract the contents of a tar file, use: 

""tar xvf mytarfile.tar""

1- x - extract
2- v - tell the program to be verbose and let us see what it's doing
3- f - the file you want to extract


Compressing/uncompressing archives with tar and gzip:
Many times you'll see a tar file that has been compressed such as: mycompressedarchive.tar.gz, 
all you need to do is work outside in, so first remove the compression with gunzip and then you can unpack the tar file. 
Or you can alternatively use the ""z"" option with tar, which just tells it to use the gzip or gunzip utility.

Create a compressed tar file:
""tar czf myfile.tar.gz""

Uncompress and unpack: 
""tar xzf file.tar""

If you need help remember this: e""X""tract all ""Z""ee ""F""iles!
        ";
 
    }

    public void lessonEightySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Packages very rarely work by themselves, they are most often accompanied by dependencies to help them run. 
For example, let's say we have a group of restaurants, these restaurants all make different cuisine, however they all get their ingredients from the same farm. 
Their food is dependent on the farm's supplies, if the farm were to suddenly stop supplying food, well then the restaurants would be in a pretty bad state. 


In Linux, these dependencies are often other packages or shared libraries. 
Shared libraries are libraries of code that other programs want to use and don't want to have to rewrite for themselves. 
Think of the restaurant again, how much work would it be if every restaurant also farmed their own food? Too much!


We will dig more into shared libraries in the filesystem course, so for now just remember that packages have dependencies to help them run, 
whether those dependencies are other packages or libraries, if the dependencies aren't there the package will end up in a broken state and most of the time not even install.
        ";
 
    }

    public void lessonEightyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Although most of this course is about package management systems (the Batmans of package management), we mustn't forget about the Robins. 
Although very useful and reliable, they don't come with that sweet batmobile and utility belt.

Just like .exe is a single executable file, so is .deb and .rpm. 
You normally wouldn't see these if you use package repositories, but if you directly download packages, you will most likely get them in these popular format. 
Obviously, they are exclusive to their distributions, .deb for Debian based and .rpm for Red Hat based.


To install these direct packages, you can use the package management commands: rpm and dpkg. 

These tools are used to install package files, however they will not install the package dependencies, so if your package had 10 dependencies, 
you would have to install those packages separately and then their dependencies and so on and so forth. 
As you can see, that was one of the reasons that brought forth the full blown management systems that we will discuss this later.

Keep in mind that there will be countless times when you need to install, query or verify a package with one of these tools, so remember these commands. 


Install a package:
Debian: ""dpkg -i some_deb_package.deb""
RPM: ""rpm -i some_rpm_package.rpm""

The ""i"" stands for install. You can also use the longer format of --install. 


Remove a package:
Debian: ""dpkg -r some_deb_package.deb""
RPM: ""rpm -e some_rpm_package.rpm""

Debian: ""r"" for remove
RPM: ""e"" for erase


List installed packages:
Debian: ""dpkg -l""
RPM: ""rpm -qa""

Debian: ""l"" for list
RPM: ""q"" for query and ""a"" for all
        ";
       
    }

    public void lessonEightyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Ah, the Batmans of package management, these systems come with all the fixins to make package installation, removal and changes easier, 
including installing package dependencies. Two of the most popular management systems is ""yum"" and ""apt"". 
""Yum"" is exclusive to the Red Hat family and ""apt"" is exclusively to the Debian family.


Install a package from a repository:
Debian: ""apt install package_name""
RPM: ""yum install package_name""


Remove a package:
Debian: ""apt remove package_name""
RPM: ""yum erase package_name""


Updating packages for a repository:
It's always best practice to update your package repositories so they are up to date before you install and update a package. 

Debian: ""apt update & apt upgrade""
RPM: ""yum update""


Get information about an installed package:
Debian: ""apt show package_name""
RPM: ""yum info package_name""
        ";
     
    }

    public void lessonNinetyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonEightyFourButton.IsVisible=false;
        lessonEightyFiveButton.IsVisible=false;
        lessonEightySixButton.IsVisible=false;
        lessonEightySevenButton.IsVisible=false;
        lessonEightyEightButton.IsVisible=false;
        lessonEightyNineButton.IsVisible=false;
        lessonNinetyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Often times you will encounter an obscure package that only comes in the form of pure source code. 
You'll need to use a few commands to get that source code package compiled and installed on your system. 

First thing is first, you'll need to have software to install the tools that will allow you to compile source code:
""sudo apt install build-essential""


Once you do that, extract the contents of the package file, most likely a .tar.gz file:
""tar -xzvf package.tar.gz""


Before you do anything, take a look at the README or INSTALL file inside the package. 
Sometimes there will be specific installation instructions. 


Depending on what compile method that the developer used, you'll have to use different commands, such as cmake or something else.
However, most commonly you'll see basic make compilation, so we'll discuss that:


Inside the package contents will be a configure script, this script checks for dependencies on your system and if you are missing anything, 
you'll see an error and you'll need to fix those dependencies. 

""./configure""
(the ""./"" allows you to execute a script in the current directory)


Inside of the package contents, there is a file called Makefile that contains rules to building the software. 
When you run the make command, it looks at this file to build the software.

""sudo make install""
This command actually installs the package, it will copy the correct files to the correct locations on your computer.


If you want to uninstall the package, use:
""sudo make uninstall""


Be wary when using make install, you may not realize how much is actually going on in the background. 
If you decide to remove this package, you may not actually remove everything because you didn't realize what was added to your system. 

Instead forget everything about make install that I just explained to you and use the ""checkinstall"" command. 
This command will make a .deb file for you that you can easily install and uninstall. 

""sudo checkinstall""
This command will essentially ""make install"" and build a .deb package and install it. This makes it easier to remove the package later on.  
        ";
     
    }

    //Journey Man Lessons
    //Devices Lessons

    public void lessonNinetyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
When you connect a device to your machine, it generally needs a device driver to function properly. 
You can interact with device drivers through device files or device nodes, these are special files that look like regular files. 
Since these device files are just like regular files, you can use programs such as ls, cat, etc to interact with them. 
These device files are generally stored in the /dev directory. Go ahead and ls the /dev directory on your system, you'll see a large amount of devices files that are on your system. 

""ls /dev""


Some of these devices you've already used and interacted with such as ""/dev/null"". 
Remember when we send output to ""/dev/null"", the kernel knows that this device takes all of our input and just discards it, so nothing gets returned.


In the old days, if you wanted to add a device to your system, you'd add the device file in /dev and then probably forget about it. 
Well repeat that a couple of times and you can see where there was a problem. 
The /dev directory would get cluttered with static device files of devices that you've long since upgraded, stopped using, etc. 

Devices are also assigned device files in the order that the kernel finds them. 
So if everytime you rebooted your system, the devices could have different device files depending on when they were discovered.


Thankfully we no longer use that method! 
Now we have something that we use to dynamically add and remove devices that are currently being used on the system and we'll be discussing this in the coming lessons.        
        ";
       
    }

    public void lessonNinetyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before we chat about how devices are managed, let's actually take a look at some devices.
""ls -l /dev""
brw-rw----   1 root disk      8,   0 Dec 20 20:13 sda
crw-rw-rw-   1 root root      1,   3 Dec 20 20:13 null
srw-rw-rw-   1 root root           0 Dec 20 20:13 log
prw-r--r--   1 root root           0 Dec 20 20:13 fdata

The columns are as follows from left to right:
1- Permissions
2- Owner
3- Group
4- Major Device Number
5- Minor Device Number
6- Timestamp
7- Device Name


Remember in the ls command you can see the type of file with the first bit on each line. Device files are denoted as the following: 
1- c - character
2- b - block
3- p - pipe
4- s - socket


Character Device:
These devices transfer data, but one a character at a time. You'll see a lot of pseudo devices (/dev/null) as character devices,
these devices aren't really physically connected to the machine, but they allow the operating system greater functionality. 


Block Device:
These devices transfer data, but in large fixed-sized blocks. 
You'll most commonly see devices that utilize data blocks as block devices, such as harddrives, filesystems, etc. 


Pipe Device:
Named pipes allow two or more processes to communicate with each other, these are similar to character devices, but instead of having output sent to a device, it's sent to another process.


Socket Device:
Socket devices facilitate communication between processes, similar to pipe devices but they can communicate with many processes at once. 


Device Characterization:
Devices are characterized using two numbers, ""major device number"" and ""minor device number"". You can see these numbers in the above ls example, they are separated by a comma.
For example, let's say a device had the device numbers: ""8, 0"":

The major device number represents the device driver that is used, in this case 8, which is often the major number for sd block devices. 
The minor number tells the kernel which unique device it is in this driver class, in this case 0 is used to represent the first device (a).
        ";
       
    }

    public void lessonNinetyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Here are the most common device names that you will encounter: 

SCSI Devices:
If you have any sort of mass storage on your machine, chances are it is using the SCSI (pronounced ""scuzzy"") protocol. 
SCSI stands for Small Computer System Interface, it is a protocol used for allow communication between disks, printers, scanners and other peripherals to your system. 

You may have heard of SCSI devices which aren't actually in use in modern systems, however our Linux systems correspond SCSI disks with hard disk drives in /dev. 
They are represented by a prefix of sd (SCSI disk):


Common SCSI device files:
1- /dev/sda - First hard disk
2- /dev/sdb - Second hard disk
3- /dev/sda3 - Third partition on the first hard disk


Pseudo Devices:
As we discussed earlier, pseudo devices aren't really physically connected to your system, most common pseudo devices are character devices: 
1- /dev/zero - accepts and discards all input, produces a continuous stream of NULL (zero value) bytes
2- /dev/null - accepts and discards all input, produces no output
3- /dev/random - produces random numbers


PATA Devices:
Sometimes in older systems you may see hard drives being referred to with an hd prefix: 
1- /dev/hda - First hard disk
2- /dev/hdd2 - Second partition on 4th hard disk
        ";
 
    }

    public void lessonNinetyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Sysfs was created long ago to better manage devices on our system that the /dev directory failed to do. 
Sysfs is a virtual filesystem, most often mounted to the /sys directory. 

It gives us more detailed information than what we would be able to see in the /dev directory. 
Both directories ""/sys"" and ""/dev"" seem to be very similar and they are in some regards, but they do have major differences. 

Basically, the /dev directory is simple, it allows other programs to access devices themselves, 
while the /sys filesystem is used to view information and manage the device. 


The /sys filesystem basically contains all the information for all devices on your system, 
such as the manufacturer and model, where the device is plugged in, the state of the device, the hierarchy of devices and more. 
The files you see here aren't device nodes, so you don't really interact with devices from the /sys directory, rather you are managing devices. 


Take a look at the contents of the /sys directory:

""ls /sys/block/sda""
alignment_offset  discard_alignment  holders   removable  sda6       trace
bdi               events             inflight  ro         size       uevent
capability        events_async       power     sda1       slaves
dev               events_poll_msecs  queue     sda2       stat
device            ext_range          range     sda5       subsystem
        ";
 
    }

    public void lessonNinetyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Back in the old days and actually today if you really wanted to, you would create device nodes using a command such as: 
""mknod /dev/sdb1 b 8 3""

This command will make a device node /dev/sdb1 and it will make it a block device (b) with a major number of 8 and a minor number of 3.


To remove a device, you would simply ""rm"" the device file in the /dev directory. 


Luckily, we really don't need to do this anymore because of udev. 
The udev system dynamically creates and removes device files for us depending on whether or not they are connected. 

There is a udevd daemon that is running on the system and it listens for messages from the kernel about devices connected to the system. 
Udevd will parse that information and it will match the data with the rules that are specified in ""/etc/udev/rules.d"", 

depending on those rules it will most likely create device nodes and symbolic links for the devices. You can write your own udev rules, but that is a little out of scope for this lesson. 
Fortunately, your system already comes with lots of udev rules so you may never need to write your own.


You can also view the udev database and sysfs using the ""udevadm"" command. 
This tool is very useful, but sometimes can get very convoluted, a simple command to view information for a device would be:

""udevadm info --query=all --name=/dev/sda""
        ";
     
    }

    public void lessonNinetySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Just like we would use the ls command to list files and directories, we can use similar tools that list information about devices.


Listing USB Devices:
""lsusb""


Listing PCI Devices:
""lspci""


Listing SCSI Devices:
""lsscsi""
        ";
        
    }

    public void lessonNinetySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyOneButton.IsVisible=false;
        lessonNinetyTwoButton.IsVisible=false;
        lessonNinetyThreeButton.IsVisible=false;
        lessonNinetyFourButton.IsVisible=false;
        lessonNinetyFiveButton.IsVisible=false;
        lessonNinetySixButton.IsVisible=false;
        lessonNinetySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The dd tool is super useful for converting and copying data. 
It reads input from a file or data stream and writes it to a file or data stream. 


Consider the following command: 
""dd if=/home/pete/backup.img of=/dev/sdb bs=1024""

This command is copying the contents of backup.img to /dev/sdb. 
It will copy the data in blocks of 1024 bytes until there is no more data to be copied. 

1- if=file - Input file, read from a file instead of standard input

2- of=file - Output file, write to a file instead of standard output

3- bs=bytes - Block size, it reads and writes this many bytes of data at a time. 
You can use different size metrics by denoting the size with a k for kilobyte, m for megabyte, etc, so 1024 bytes is 1k

4- count=number - Number of blocks to copy.


You will see some dd commands that use the count option, usually with dd if you want to copy a file that is 1 megabyte, 
you'll usually want to see that file as 1 megabyte when it's done being copied. Let's say you run the following command: 

""dd if=/home/pete/backup.img of=/dev/sdb bs=1M count=2""

Our backup.img file is 10M, however, we are saying in this command to copy over 1M 2 times, so only 2M is being copied, leaving our copied data incomplete. 
Count can come in handy in many situations, but if you are just copying over data, you can pretty much omit count and even bs for that matter. 
If you really want to optimize your data transfers, then you'll want to start using those options.


dd is extremely powerful, you can use it to make backups of anything, including whole disk drives, restoring disks images, and more. 
Be careful, that powerful tool can come at a price if you aren't sure what you are doing.        
        ";
 
    }
    
    //The Filesystem lessons

    public void lessonNinetyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
At this point, you're probably well familiar with the directory structure of your system, if not you will be soon. 
Filesystems can vary with how they are structured, but for the most part they should conform to the Filesystem Hierarchy Standard. 


Go ahead and do an ""ls -l"" to see the directories listed under the root directory, yours may look different than mine, but the directories should for the most part look like the following:

1- / - The root directory of the entire filesystem hierarchy, everything is nestled under this directory.
2- /bin - Essential ready-to-run programs (binaries), includes the most basic commands such as ls and cp.
3- /boot - Contains kernel boot loader files.
4- /dev - Device files.
5- /etc - Core system configuration directory, should hold only configuration files and not any binaries.
6- /home - Personal directories for users, holds your documents, files, settings, etc.
7- /lib - Holds library files that binaries can use.
8- /media - Used as an attachment point for removable media like USB drives.
9- /mnt - Temporarily mounted filesystems.
10- /opt - Optional application software packages.
11- /proc - Information about currently running processes.
12- /root - The root user's home directory.
13- /run - Information about the running system since the last boot.
14- /sbin - Contains essential system binaries, usually can only be ran by root.
15- /srv - Site-specific data which are served by the system.
16- /tmp - Storage for temporary files

17- /usr - This is unfortunately named, most often it does not contain user files in the sense of a home folder. 
This is meant for user installed software and utilities, however that is not to say you can't add personal directories in there. 
Inside this directory are sub-directories for /usr/bin, /usr/local, etc.

18- /var - Variable directory, it's used for system logging, user tracking, caches, etc. Basically anything that is subject to change all the time.
        ";
     
    }

    public void lessonNinetyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
There are many different filesystem implementations available. 
Some are faster than others, some support larger capacity storage and others only work on smaller capacity storage. 
Different filesystems have different ways of organizing their data and we'll go into detail about what types of filesystems there are. 
Since there are so many different implementations available, applications need a way to deal with the different operations. 

So there is something called the Virtual File System (VFS) abstraction layer. 
It is a layer between applications and the different filesystem types, so no matter what filesystem you have, your applications will be able to work with it. 


You can have many filesystem on your disks, depending on how they are partitioned and we will go through that in a coming lesson.


Journaling:
Journaling comes by default on most filesystem types, but just in case it doesn't, you should know what it does. 
Let's say you're copying a large file and all of a sudden you lose power. 

Well if you are on a non-journaled filesystem, the file would end up corrupted and your filesystem would be inconsistent and then when you boot back up, 
your system would perform a filesystem check to make sure everything is ok. However, the repairs could take awhile depending on how large your filesystem was. 

Now if you were on a journaled system, before your machine even begins to copy the file, it will write what you're going to be doing in a log file (journal). 
Now when you actually copy the file, once it completes, the journal marks that task as complete. 
The filesystem is always in a consistent state because of this, so it will know exactly where you left off if your machine shutdown suddenly. 
This also decreases the boot time because instead of checking the entire filesystem it just looks at your journal.


Common Desktop Filesystem Types:
1- ext4 - This is the most current version of the native Linux filesystems. It is compatible with the older ext2 and ext3 versions. 
It supports disk volumes up to 1 exabyte and file sizes up to 16 terabytes and much more. It is the standard choice for Linux filesystems.

2- Btrfs - ""Better or Butter FS"" it is a new filesystem for Linux that comes with snapshots, incremental backups, performance increase and much more. 
It is widely available, but not quite stable and compatible yet.

3- XFS - High performance journaling file system, great for a system with large files such as a media server.

4- NTFS and FAT - Windows filesystems

5- HFS+ - Macintosh filesystem


Check out what filesystems are on your machine: 
""df -T""
Filesystem     Type     1K-blocks    Used Available Use% Mounted on
/dev/sda1      ext4       6461592 2402708   3707604  40% /
udev           devtmpfs    501356       4    501352   1% /dev
tmpfs          tmpfs       102544    1068    101476   2% /run
/dev/sda6      xfs       13752320  460112  13292208   4% /home

The ""df"" command reports file system disk space usage and other details about your disk, we will talk more about this tool later.        
        ";
        
    }

    public void lessonOneHundredButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Hard disks can be subdivided into partitions, essentially making multiple block devices. Recall such examples as, /dev/sda1 and /dev/sda2, /dev/sda is the whole disk, but /dev/sda1 is the first partition on that disk. 
Partitions are extremely useful for separating data and if you need a certain filesystem, you can easily create a partition instead of making the entire disk one filesystem type.


Partition Table:
Every disk will have a partition table, this table tells the system how the disk is partitioned. 
This table tells you where partitions begin and end, which partitions are bootable, what sectors of the disk are allocated to what partition,etc. 
There are two main partition table schemes used, Master Boot Record (MBR) and GUID Partition Table (GPT).


Partition:
Disks are comprised of partitions that help us organize our data. You can have multiple partitions on a disk and they can't overlap each other. If there is space that is not allocated to a partition, then it is known as free space. 
The types of partitions depend on your partition table. Inside a partition, you can have a filesystem or dedicate a partition to other things like swap (we'll get to that soon).


MBR:
1- Traditional partition table, was used as the standard
2- Can have primary, extended, and logical partitions
3- MBR has a limit of four primary partitions
4- Additional partitions can be made by making a primary partition into an extended partition (there can only be one extended partition on a disk). 
Then inside the extended partition you add logical partitions. The logical partitions are used just like any other partition. Silly I know.
5- Supports disks up to 2 terabytes


GPT:
1- GUID Partition Table (GPT) is becoming the new standard for disk partitioning
2- Has only one type of partition and you can make many of them
3- Each partition has a globally unique ID (GUID)
4- Used mostly in conjunction with UEFI based booting (we'll get into details in another course)


Filesystem Structure:
We know from our previous lesson that a filesystem is an organized collection of files and directories. In its simplest form, 
it is comprised of a database to manage files and the actual files themselves, however we're going to go into a little more detail. 

1- Boot block - This is located in the first few sectors of the filesystem, and it's not really used the by the filesystem. 
Rather, it contains information used to boot the operating system. Only one boot block is needed by the operating system. If you have multiple partitions, they will have boot blocks, but many of them are unused.
2- Super block - This is a single block that comes after the boot block, and it contains information about the filesystem, such as the size of the inode table, size of the logical blocks and the size of the filesystem.
3- Inode table - Think of this as the database that manages our files (we have a whole lesson on inodes, so don't worry). Each file or directory has a unique entry in the inode table and it has various information about the file.
4- Data blocks - This is the actual data for the files and directories.
 

Let's take a look at the different partition tables. Below is an example of a partition using the MBR partitioning table (msdos). You can see the primary, extended and logical partitions on the machine:
""sudo parted -l""
Model: Seagate (scsi)
Disk /dev/sda: 21.5GB
Sector size (logical/physical): 512B/512B
Partition Table: msdos

Number  Start   End     Size    Type      File system     Flags
 1      1049kB  6860MB  6859MB  primary   ext4            boot
 2      6861MB  21.5GB  14.6GB  extended
 5      6861MB  7380MB  519MB   logical   linux-swap(v1)
 6      7381MB  21.5GB  14.1GB  logical   xfs


This example is GPT, using just a unique ID for the partitions.

Model: Thumb Drive (scsi)
Disk /dev/sdb: 4041MB
Sector size (logical/physical): 512B/512B
Partition Table: gpt

Number  Start   End     Size     File system  Name        Flags
 1      17.4kB  1000MB  1000MB                first
 2      1000MB  4040MB  3040MB                second
        ";
       
    }

    public void lessonOneHundredOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's do some practical stuff with filesytems by working through the process on a USB drive. If you don't have one, no worries, you can still follow along these next couple of lessons. 

First we'll need to partition our disk. There are many tools available to do this: 
1- fdisk - basic command-line partitioning tool, it does not support GPT
2- parted - this is a command line tool that supports both MBR and GPT partitioning
3- gparted - this is the GUI version of parted
4- gdisk - fdisk, but it does not support MBR only GPT

Let's use parted to do our partitioning. Let's say I connect the USB device and we see the device name is /dev/sdb2. 
Launch parted: ""sudo parted""
You'll be entered in the parted tool, here you can run commands to partition your device. 


Select the device:
""select /dev/sdb2""
To select the device you'll be working with, select it by its device name.


View current partition table:
(parted) print                                                            
Model: Seagate (scsi)
Disk /dev/sda: 21.5GB
Sector size (logical/physical): 512B/512B
Partition Table: msdos

Number  Start   End     Size    Type      File system     Flags
 1      1049kB  6860MB  6859MB  primary   ext4            boot
 2      6861MB  21.5GB  14.6GB  extended
 5      6861MB  7380MB  519MB   logical   linux-swap(v1)
 6      7381MB  21.5GB  14.1GB  logical   xfs

Here you will see the available partitions on the device. The ""start"" and ""end"" points are where the partitions take up space on the hard drive, 
you'll want to find a good start and end location for your partitions. 


Partition the device:
""mkpart primary 123 4567""
Now just choose a start and end point and make the partition, you'll need to specify the type of partition depending on what table you used. 


Resize a partition:
You can also resize a partition if you don't have any space:
""resize 2 1245 3456""
Select the partition number and then the start and end points of where you want to resize it to. 


Parted is a very powerful tool and you should be careful when partitioning your disks. 
        ";
 
    }

    public void lessonOneHundredTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now that you've actually partitioned a disk, let's create a filesystem!
""sudo mkfs -t ext4 /dev/sdb2""


Simple as that! 
The ""mkfs"" (make filesystem) tool allows us to specify the type of filesystem we want and where we want it. 

You'll only want to create a filesystem on a newly partitioned disk or if you are repartitioning an old one. 
You'll most likely leave your filesystem in a CORRUPTED state if you try to create one on top of an existing one. 
        ";
       
    }

    public void lessonOneHundredThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before you can view the contents of your filesystem, you will have to mount it. 

To do that I'll need the device location, the filesystem type and a mount point, 
the mount point is a directory on the system where the filesystem is going to be attached. 
So we basically want to mount our device to a mount point. 

First create the mount point, in our case ""mkdir /mydrive""
""sudo mount -t ext4 /dev/sdb2 /mydrive""

Simple as that! Now when we go to /mydrive we can see our filesystem contents, 
the ""-t"" specifies the type of filesystem, then we have the device location, then the mount point. 


To unmount a device from a mount point: 
""sudo umount /mydrive""
or 
""sudo umount /dev/sdb2""


Remember that the kernel names devices in the order it finds them. What if our device name changes for some reason after we mount it? 
Well fortunately, you can use a device's universally unique ID (UUID) instead of a name.

To view the UUIDS on your system for block devices:
""sudo blkid""
/dev/sda1: UUID=""130b882f-7d79-436d-a096-1e594c92bb76"" TYPE=""ext4""
/dev/sda5: UUID=""22c3d34b-467e-467c-b44d-f03803c2c526"" TYPE=""swap"" 
/dev/sda6: UUID=""78d203a0-7c18-49bd-9e07-54f44cdb5726"" TYPE=""xfs""

We can see our device names, their corresponding filesystem types and their UUIDs. Now when we want to mount something, we can use:
""sudo mount UUID=130b882f-7d79-436d-a096-1e594c92bb76 /mydrive""


Most of the time you won't need to mount devices via their UUIDs, 
it's much easier to use the device name and often times the operating system will know to mount common devices like USB drives. 

If you need to automatically mount a filesystem at startup though like if you added a secondary hard drive, 
you'll want to use the UUID and we'll go over that in the next lesson.       
        ";
 
    }

    public void lessonOneHundredFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
When we want to automatically mount filesystems at startup we can add them to a file called /etc/fstab (pronounced ""eff es tab"" not ""eff stab"") 
short for filesystem table. This file contains a permanent list of filesystems that are mounted.


""cat /etc/fstab""
UUID=130b882f-7d79-436d-a096-1e594c92bb76 /               ext4    relatime,errors=remount-ro 0       1
UUID=78d203a0-7c18-49bd-9e07-54f44cdb5726 /home           xfs     relatime        0       2
UUID=22c3d34b-467e-467c-b44d-f03803c2c526 none            swap    sw              0       0

Each line represents one filesystem, the fields are: 

1- UUID - Device identifier
2- Mount point - Directory the filesystem is mounted to
3- Filesystem type
4- Options - other mount options, see manpage for more details
5- Dump - used by the dump utility to decide when to make a backup, you should just default to 0
6- Pass - Used by fsck to decide what order filesystems should be checked, if the value is 0, it will not be checked


To add an entry, just directly modify the /etc/fstab file using the entry syntax above. 
Be careful when modifying this file, you could potentially make your life a little harder if you mess up.        
        ";
        
    }

    public void lessonOneHundredFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In our previous example, I showed you how to see your partition table, let's revisit that example, more specifically this line:
Number  Start   End     Size    Type      File system     Flags
 5      6861MB  7380MB  519MB   logical   linux-swap(v1)


What is this swap partition? Well swap is what we used to allocate virtual memory to our system. 
If you are low on memory, the system uses this partition to ""swap"" pieces of memory of idle processes to the disk, so you're not bogged for memory.


Using a partition for swap space:
Let's say we wanted to set our partition of /dev/sdb2 to be used for swap space. 

1- First make sure we don't have anything on the partition
2- Run: mkswap /dev/sdb2 to initialize swap areas
3- Run: swapon /dev/sdb2 this will enable the swap device
4- If you want the swap partition to persist on bootup, you need to add an entry to the /etc/fstab file. sw is the filesystem type that you'll use.
5- To remove swap: swapoff /dev/sdb2


Generally you should allocate about twice as much swap space as you have memory. 
But modern systems today are usually pretty powerful enough and have enough RAM as it is.       
        ";
     
    }

    public void lessonOneHundredSixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
There are a few tools you can used to see the utilization of your disks: 
""df -h""
Filesystem     1K-blocks    Used Available Use% Mounted on
/dev/sda1       6.2G  2.3G  3.6G  40% /


The df command shows you the utilization of your currently mounted filesystems. 
The -h flag gives you a human readable format. 
You can see what the device is, and how much capacity is used and available. 


Let's say your disk is getting full and you want to know what files or directories are taking up that space, 
for that you can use the ""du"" command. 

""du -h""

This shows you the disk usage of the current directory you are in, 
you can take a peek at the root directory with ""du -h /"" but that can get a little cluttered.


Both of these commands are so similar in syntax it can be hard to remember which one to use:
to check how much of your disk is FREE use df. 
To check disk USAGE, use du.
        ";
        
    }

    public void lessonOneHundredSevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Sometimes our filesystem isn't always in the best condition, if we have a sudden shutdown, our data can become corrupt. 
It's up to the system to try to get us back in a working state (although we sure can try ourselves). 


The ""fsck"" (filesystem check) command is used to check the consistency of a filesystem and can even try to repair it for us. 
Usually when you boot up a disk, fsck will run before your disk is mounted to make sure everything is ok. 

Sometimes though, your disk is so bad that you'll need to manually do this. 
HOWEVER, BE SURE TO DO THIS WHILE YOU ARE IN A RESCUE DISK OR SOMEWHERE WHERE YOU CAN ACCESS YOUR FILESYSTEM WITHOUT IT BEING MOUNTED.


""sudo fsck /dev/sda""
        ";
       
    }

    public void lessonOneHundredEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Remember how our filesystem is comprised of all our actual files and a database that manages these files? The database is known as the inode table. 

What is an inode?:
An inode (index node) is an entry in this table and there is one for every file. It describes everything about the file, such as:

1- File type - regular file, directory, character device, etc
2- Owner
3- Group
4- Access permissions
5- Timestamps - mtime (time of last file modification), ctime (time of last attribute change), atime (time of last access)
6- Number of hardlinks to the file
7- Size of the file
8- Number of blocks allocated to the file
9- Pointers to the data blocks of the file - most important!

Basically inodes store everything about the file, except the filename and the file itself!


When are inodes created?:
When a filesystem is created, space for inodes is allocated as well. 
There are algorithms that take place to determine how much inode space you need depending on the volume of the disk and more. 
You've probably at some point in your life seen errors for out of disk space issues. 
Well the same can occur for inodes as well (although less common), you can run out of inodes and therefore be unable to create more files. Remember data storage depends on both the data and the database (inodes). 

To see how many inodes are left on your system, use the command ""df -i""


Inode information:
Inodes are identified by numbers, when a file gets created it is assigned an inode number, the number is assigned in sequential order. 
However, you may sometimes notice when you create a new file, it gets an inode number that is lower than others, this is because once inodes are deleted, they can be reused by other files. 

To view inode numbers run ""ls -li"":
""ls -li""
140 drwxr-xr-x 2 pete pete 6 Jan 20 20:13 Desktop
141 drwxr-xr-x 2 pete pete 6 Jan 20 20:01 Documents

The first field in this command lists the inode number.

You can also see detailed information about a file with stat, it tells you information about the inode as well:
""stat ~/Desktop/""
  File: ‘/home/pete/Desktop/’
  Size: 6               Blocks: 0          IO Block: 4096   directory
Device: 806h/2054d      Inode: 140         Links: 2
Access: (0755/drwxr-xr-x)  Uid: ( 1000/   pete)   Gid: ( 1000/   pete)
Access: 2016-01-20 20:13:50.647435982 -0800
Modify: 2016-01-20 20:13:06.191675843 -0800
Change: 2016-01-20 20:13:06.191675843 -0800
 Birth: -


How do inodes locate files?:
We know our data is out there on the disk somewhere, unfortunately it probably wasn't stored sequentially, so we have to use inodes. 
Inodes point to the actual data blocks of your files. In a typical filesystem (not all work the same), each inode contains 15 pointers, the first 12 pointers point directly to the data blocks. 
The 13th pointer, points to a block containing pointers to more blocks, the 14th pointer points to another nested block of pointers, and the 15th pointer points yet again to another block of pointers! 
Confusing, I know! The reason this is done this way is to keep the inode structure the same for every inode, but be able to reference files of different sizes. 
If you had a small file, you could find it quicker with the first 12 direct pointers, larger files can be found with the nests of pointers. Either way the structure of the inode is the same.       
        ";
       
    }
    
    public void lessonOneHundredNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's use a previous example of inode information: 
""ls -li""
140 drwxr-xr-x 2 pete pete 6 Jan 20 20:13 Desktop
141 drwxr-xr-x 2 pete pete 6 Jan 20 20:01 Documents

You may have noticed that we've been glossing over the third field in the ls command, that field is the link count. The link count is the total number of hard links a file has, 
well that doesn't mean anything to you right now. So let's discuss links first. 


Symlinks:
In the Windows operating system, there are things known as shortcuts, shortcuts are just aliases to other files. 
If you do something to the original file, you could potentially break the shortcut. In Linux, the equivalent of shortcuts are symbolic links (or soft links or symlinks). 
Symlinks allow us to link to another file by its filename.

Another type of links found in Linux are ""Hardlinks"" (we will take a look at them on the next lesson), these are actually another file with a link to an inode.


Let's see what I mean in practice starting with symlinks.

""echo 'myfile' > myfile""
""echo 'myfile2' > myfile2""
""echo 'myfile3' > myfile3""

""ln -s myfile myfilelink""
""ls -li""
total 12
  151 -rw-rw-r-- 1 pete pete 7 Jan 21 21:36 myfile
93401 -rw-rw-r-- 1 pete pete 8 Jan 21 21:36 myfile2
93402 -rw-rw-r-- 1 pete pete 8 Jan 21 21:36 myfile3
93403 lrwxrwxrwx 1 pete pete 6 Jan 21 21:39 myfilelink -> myfile


You can see that I've made a symbolic link named myfilelink that points to myfile. 
Symbolic links are denoted by ->. Notice how I got a new inode number though, symlinks are just files that point to filenames. 

When you modify a symlink, the file also gets modified. 
Inode numbers are unique to filesystems, you can't have two of the same inode number in a single filesystem, meaning you can't reference a file in a different filesystem by its inode number. 
However, if you use symlinks they do not use inode numbers, they use filenames, so they can be referenced across different filesystems. 


Creating a symlink:
""ln -s myfile mylink""
To create a symbolic link, you use the ln command with -s for symbolic and you specific a target file and then a link name. 
     
        ";
 
    }

    public void lessonOneHundredNineExtraButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonNinetyEightButton.IsVisible=false;
        lessonNinetyNineButton.IsVisible=false;
        lessonOneHundredButton.IsVisible=false;
        lessonOneHundredOneButton.IsVisible=false;
        lessonOneHundredTwoButton.IsVisible=false;
        lessonOneHundredThreeButton.IsVisible=false;
        lessonOneHundredFourButton.IsVisible=false;
        lessonOneHundredFiveButton.IsVisible=false;
        lessonOneHundredSixButton.IsVisible=false;
        lessonOneHundredSevenButton.IsVisible=false;
        lessonOneHundredEightButton.IsVisible=false;
        lessonOneHundredNineButton.IsVisible=false;
        lessonOneHundredNineExtraButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Hardlinks:
Hardlinks are actually another file with a link to an inode.

Let's see an example of a hardlink:

""ln myfile2 myhardlink""
""ls -li""
total 16
  151 -rw-rw-r-- 1 pete pete 7 Jan 21 21:36 myfile
93401 -rw-rw-r-- 2 pete pete 8 Jan 21 21:36 myfile2
93402 -rw-rw-r-- 1 pete pete 8 Jan 21 21:36 myfile3
93403 lrwxrwxrwx 1 pete pete 6 Jan 21 21:39 myfilelink -> myfile
93401 -rw-rw-r-- 2 pete pete 8 Jan 21 21:36 myhardlink

A hardlink just creates another file with a link to the same inode. 
So if I modified the contents of myfile2 or myhardlink, the change would be seen on both, but if I deleted myfile2, the file would still be accessible through myhardlink. 

Here is where our link count in the ls command comes into play. 
The link count is the number of hardlinks that an inode has, when you remove a file, it will decrease that link count. 

The inode only gets deleted when all hardlinks to the inode have been deleted. 
When you create a file, it's link count is 1 because it is the only file that is pointing to that inode. 
Unlike symlinks, hardlinks do not span filesystems because inodes are unique to the filesystem. 


Creating a hardlink:
""ln somefile somelink""

Similar to a symlink creation, except this time you leave out the -s.       
        ";
 
    }

    //Boot Lessons

    public void lessonOneHundredTenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=false;
        lessonOneHundredElevenButton.IsVisible=false;
        lessonOneHundredTwelveButton.IsVisible=false;
        lessonOneHundredThirteenButton.IsVisible=false;
        lessonOneHundredFourteenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Now that we've gotten a pretty good grasp at some of the important components of Linux, let's piece them altogether by learning about how the system boots. 
When you turn on your machine, it does some neat things like show you the logo screen, run through some different messages and then at the end you're prompted with a login window. 

Well there is actually a ton of stuff happening between when you push the power button to when you login and we'll discuss those in this course. 


The Linux boot process can be broken down in 4 simple stages: 
1- BIOS:
The BIOS (stands for ""Basic Input/Output System"") initializes the hardware and makes sure with a Power-on self test (POST) that all the hardware is good to go. 
The main job of the BIOS is to load up the bootloader.


2- Bootloader:
The bootloader loads the kernel into memory and then starts the kernel with a set of kernel parameters. 
One of the most common bootloaders is GRUB, which is a universal Linux standard. 


3- Kernel:
When the kernel is loaded, it immediately initializes devices and memory. 
The main job of the kernel is to load up the init process. 


4- Init:
Remember the init process is the first process that gets started, init starts and stops essential service process on the system. 
There are three major implementations of init in Linux distributions. We will go over them briefly and then dive into them in another course.


There it is, the (very) simple explanation of the Linux boot process. 
We will go into more detail about these stages in the next lessons.        
        ";
        
    }

    public void lessonOneHundredElevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=false;
        lessonOneHundredElevenButton.IsVisible=false;
        lessonOneHundredTwelveButton.IsVisible=false;
        lessonOneHundredThirteenButton.IsVisible=false;
        lessonOneHundredFourteenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
BIOS:
The first step in the Linux boot process is the BIOS which performs system integrity checks. 
The BIOS is a firmware that comes most common in IBM PC compatible computers, the dominant type of computers out there today. 

You've probably used the BIOS firmware to change the boot order of your harddisks, check system time, your machine's mac address, etc. 
The BIOS's main goal is to find the system bootloader.


So once the BIOS boots up the hard drive, it searches for the boot block to figure out how to boot up the system. 
Depending on how you partition your disk, it will look to the master boot record (MBR) or GPT. 

The MBR is located in the first sector of the hard drive, the first 512 bytes. 
The MBR contains the code to load another program somewhere on the disk, this program in turn actually loads up our bootloader. 


Now if you partitioned your disk with GPT, the location of the bootloader changes a bit.


UEFI:
There is another way to boot up your system instead of using BIOS and that is with UEFI (stands for ""Unified extensible firmware interface""). 
UEFI was designed to be successor to BIOS, most hardware out there today comes with UEFI firmware built in. 
Macintosh machines have been using EFI booting for years now and Windows has mostly moved all of their stuff over to UEFI booting. 
The GPT format was intended for use with EFI. You don't necessarily need EFI if you are booting a GPT disk. 

The first sector of a GPT disk is reserved for a ""protective MBR"" to make it possible to boot a BIOS-based machine.


UEFI stores all the information about startup in an .efi file. 
This file is stored on a special partition called EFI system partition on the hardware. 
Inside this partition it will contain the bootloader. 

UEFI comes with many improvements from the traditional BIOS firmware. 
However, since we are using Linux, the majority of us are using BIOS. 
So all of these lessons will be going along with that pretense.       
        ";
     
    }

    public void lessonOneHundredTwelveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=false;
        lessonOneHundredElevenButton.IsVisible=false;
        lessonOneHundredTwelveButton.IsVisible=false;
        lessonOneHundredThirteenButton.IsVisible=false;
        lessonOneHundredFourteenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The bootloader's main responsibilities are:

1- Booting into an operating system, it can also be used to boot to non-Linux operating systems
2- Select a kernel to use
3- Specify kernel parameters


The most common bootloader for Linux is GRUB, you are most likely using it on your system. 
There are many other bootloaders that you can use such as LILO, efilinux, coreboot, SYSLINUX and more. 
However, we will just be working with GRUB as our bootloader. 


So we know that the bootloader's main goal is to load up the kernel, but where does it find the kernel? 
To find it, we will need to look at our kernel parameters. 

The parameters can be found by going into the GRUB menu on startup using the ""e"" key. 
If you don't have GRUB no worries, we'll go through the boot parameters that you will see:


1- initrd - Specifies the location of initial RAM disk (we'll talk more about this in the next lesson).
2- BOOT_IMAGE  - This is where the kernel image is located

3- root - The location of the root filesystem, the kernel searches inside this location to find init. 
It is often represented by it's UUID or the device name such as /dev/sda1.

4- ro - This parameter is pretty standard, it mounts the fileystem as read-only mode.
5- quiet - This is added so that you don't see display messages that are going on in the background during boot.
6- splash - This lets the splash screen be shown.
        ";
        
    }

    public void lessonOneHundredThirteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=false;
        lessonOneHundredElevenButton.IsVisible=false;
        lessonOneHundredTwelveButton.IsVisible=false;
        lessonOneHundredThirteenButton.IsVisible=false;
        lessonOneHundredFourteenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
So now that our bootloader has passed on the necessary parameters, let's see how it get's started:


Initrd vs Initramfs:
There is a bit of a chicken and egg problem when we talk about the kernel bootup. 
The kernel manages our systems hardware, however not all drivers are available to the kernel during bootup. 

So we depend on a temporary root filesystem that contains just the essential modules that the kernel needs to get to the rest of the hardware. 
In older versions of Linux, this job was given to the initrd (initial ram disk). 
The kernel would mount the initrd, get the necessary bootup drivers, then when it was done loading everything it needed, it would replace the initrd with the actual root filesystem. 

These days, we have something called the initramfs, 
this is a temporary root filesystem that is built into the kernel itself to load all the necessary drivers for the real root filesystem, so no more locating the initrd file. 


Mounting the root filesystem:
Now the kernel has all the modules it needs to create a root device and mount the root partition. 
Before you go any further though, the root partition is actually mounted in read-only mode first so that fsck can run safely and check for system integrity. 

Afterwards it remounts the root filesystem in read-write mode. 
Then the kernel locates the init program and executes it.         
        ";
     
    }

    public void lessonOneHundredFourteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=false;
        lessonOneHundredElevenButton.IsVisible=false;
        lessonOneHundredTwelveButton.IsVisible=false;
        lessonOneHundredThirteenButton.IsVisible=false;
        lessonOneHundredFourteenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We've discussed init in previous lessons and know that it is the first process that gets started, 
and it starts all the other essential services on our system. But how?


There are actually three major implementations of init in Linux: 

System V init (sysv):
This is the traditional init system. It sequentially starts and stops processes, based on startup scripts. 
The state of the machine is denoted by runlevels, each runlevel starts or stops a machine in a different way. 


Upstart:
This is the init you'll find on older Ubuntu installations. 
Upstart uses the idea of jobs and events and works by starting jobs that performs certain actions in response to events. 


Systemd:
This is the new standard for init, it is goal oriented. 
Basically you have a goal that you want to achieve and systemd tries to satisfy the goal's dependencies to complete the goal. 

We have an entire course on Init systems where we will dive into each of these systems in more detail.        
        ";
        
    }

    //Kernel Lessons

    public void lessonOneHundredFifteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=false;
        lessonOneHundredSixteenButton.IsVisible=false;
        lessonOneHundredSeventeenButton.IsVisible=false;
        lessonOneHundredEighteenButton.IsVisible=false;
        lessonOneHundredNineteenButton.IsVisible=false;
        lessonOneHundredTwentyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
As you've learned up to this point, the kernel is the core of the operating system. 
We've talked about the other parts of the operating system but have yet to show how they all work together. 
The Linux operating system can be organized into 3 different levels of abstraction.


1- The most basic level is hardware, this includes our CPU, memory, hard disks, networking ports, etc. 
The physical layer that actually computes what our machine is doing.


2- The next level is the kernel, which handles process and memory management, device communication, system calls, sets up our filesystem, etc. 
The kernel's job is to talk to the hardware to make sure it does what we want our processes to do. 


3- And the level that you are familiar with is the user space, the user space includes the shell, the programs that you run, the graphics, etc.


In this course, we'll be focusing on the kernel and learning its intricacies.        
        ";
  
    }

    public void lessonOneHundredSixteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=false;
        lessonOneHundredSixteenButton.IsVisible=false;
        lessonOneHundredSeventeenButton.IsVisible=false;
        lessonOneHundredEighteenButton.IsVisible=false;
        lessonOneHundredNineteenButton.IsVisible=false;
        lessonOneHundredTwentyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The next few lessons get pretty theoretical, so if you're looking for some practical stuff you can skip ahead and come back later.


Why do we have different abstraction layers for user space and kernel? Why can't you combine both powers into one layer? 
Well there is a very good reason why these two layers exist separately!
They both operate in different modes, the kernel operates in ""kernel mode"" and the user space operates in ""user mode"". 


In kernel mode, the kernel has complete access to the hardware, it controls everything. 
In user space mode, there is a very small amount of safe memory and CPU that you are allowed to access. 
Basically, when we want to do anything that involves hardware, 
reading data from our disks, writing data to our disks, controlling our network, etc, it is all done in kernel mode. 

Why is this necessary? Imagine if your machine was infected with spyware, you wouldn't want it to be able to have direct access to your system's hardware. 
It can access all your data, your webcam, etc. and that's no good!


These different modes are called privilege levels (aptly named for the levels of privilege you get) and are often described as protection rings. 

To make this picture easier to paint, let's say you find out that Britney Spears is in town at your local klerb, 
she's protected by her groupies, then her personal bodyguards, then the bouncer outside the klerb. 
You want to get her autograph (because why not?), but you can't get to her because she is heavily protected. 
The rings work the same way, the innermost ring corresponds to the highest privilege level. 


There are two main levels or modes in an x86 computer architecture. 
Ring #3 is the privilege that user mode applications run in, Ring #0 is the privilege that the kernel runs in. 

Ring #0 can execute any system instruction and is given full trust. 


So now that we know how those privilege levels work, how are we able to write anything to our hardware? 
Won't we always be in a different mode than the kernel? 


The answer is with system calls, system calls allow us to perform a privileged instruction in kernel mode and then switch back to user mode.
        ";
        
    }

    public void lessonOneHundredSeventeenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=false;
        lessonOneHundredSixteenButton.IsVisible=false;
        lessonOneHundredSeventeenButton.IsVisible=false;
        lessonOneHundredEighteenButton.IsVisible=false;
        lessonOneHundredNineteenButton.IsVisible=false;
        lessonOneHundredTwentyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Remember Britney in the previous lesson? Let's say we want to see her and get some drinks together.
How do we get from standing outside in the crowds of people to inside her innermost circle? We would use system calls. 

System calls are like the VIP passes that get you to a secret side door that leads directly to Britney.


System calls (syscall) provide user space processes a way to request the kernel to do something for us. 
The kernel makes certain services available through the system call API. 
These services allow us to read or write to a file, modify memory usage, modify our network, etc. 

The amount of services are fixed, 
so you can't be adding system calls nilly willy, your system already has a table of what system calls exist and each system call has a unique ID. 


I won't get into specifics of system calls, as that will require you to know a bit of C, but the basics is that when you call a program like ls, 
the code inside this program contains a system call wrapper (so not the actual system call yet). 
Inside this wrapper it invokes the system call which will execute a trap, this trap then gets caught by the system call handler and then references the system call in the system call table. 

Let's say we are trying to call the stat() system call, it's identified by a syscall ID and the purpose of the stat() system call is to query the status of a file. 
Now remember, you were running the ls program in non-privilege mode. 
So now it sees you're trying to make a syscall, it then switches you over to kernel mode, there it does lots of things but most importantly it looks up your syscall number, 
finds it in a table based on the syscall ID and then executes the function you wanted to run. 

Once it's done, it will return back to user mode and your process will receive a return status if it was successful or if it had an error. 
The inner workings of syscalls get really detailed, I would recommend looking at information online if you want to learn more!


You can actually view the system calls that a process makes with the ""strace"" command. 
The strace command is useful for debugging how a program executed. 


""strace ls""
        ";
 
    }

    public void lessonOneHundredEighteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=false;
        lessonOneHundredSixteenButton.IsVisible=false;
        lessonOneHundredSeventeenButton.IsVisible=false;
        lessonOneHundredEighteenButton.IsVisible=false;
        lessonOneHundredNineteenButton.IsVisible=false;
        lessonOneHundredTwentyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Ok, now that we've got all that boring stuff out of the way, let's talk about actually installing and modifying kernels. 
You can install multiple kernels on your system, remember in our lesson on the boot process? 
In our GRUB menu we can choose which kernel to boot to. 


To see what kernel version you have on your system, use the following command:
""uname -r""
3.19.0-43-generic

The uname command prints system information, the -r command will print out all of the kernel release version.


You can install the Linux kernel in different ways, you can download the source package and compile from source or you can install it using package management tools.
""sudo apt install linux-generic-lts-vivid""


and then just reboot into the kernel you installed. Simple right? 
Kind of, you'll need to also install other linux packages such as the linux-headers, linux-image-generic, etc). 
You can also specify the version number, so the above command can look like, ""sudo apt install 3.19.0-43-generic""


Alternatively, if you just want the updated kernel version, just use ""dist-upgrade"", it performs upgrades to all package on your system:
""sudo apt dist-upgrade""


There are many different kernel versions, some are used as LTS (long term support), some are the latest and greatest, 
the compatibility may be very different between kernel versions so you may want to try out different kernels.        
        ";
       
    }

    public void lessonOneHundredNineteenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=false;
        lessonOneHundredSixteenButton.IsVisible=false;
        lessonOneHundredSeventeenButton.IsVisible=false;
        lessonOneHundredEighteenButton.IsVisible=false;
        lessonOneHundredNineteenButton.IsVisible=false;
        lessonOneHundredTwentyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
What happens when you install a new kernel? Well it actually adds a couple of files to your system, 
these files are usually added to the ""/boot"" directory. 


You will see multiple files for different kernel versions:

1- vmlinuz - this is the actual linux kernel
2- initrd - as we've discussed before, the initrd is used as a temporary file system, used before loading the kernel
3- System.map - symbolic lookup table
4- config - kernel configuration settings, if you are compiling your own kernel, you can set which modules can be loaded


If your /boot directory runs out of space, you can always delete old versions of these files or just use a package manager, 
but be careful when doing maintenance in this directory and don't accidentally delete the kernel you are using.       
        ";
        
    }

    public void lessonOneHundredTwentyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=false;
        lessonOneHundredSixteenButton.IsVisible=false;
        lessonOneHundredSeventeenButton.IsVisible=false;
        lessonOneHundredEighteenButton.IsVisible=false;
        lessonOneHundredNineteenButton.IsVisible=false;
        lessonOneHundredTwentyButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's say I have a sweet ride, I invest a lot of time and money into it. 
I add a spoiler, hitch, bike rack and other random things. 
These components don't actually change the core functionality of the car and I can remove and add them very easily. 
The kernel uses the same concept with kernel modules.


The kernel in itself is a monolithic piece of software, when we want to add support for a new type of keyboard, we don't write this code directly into the kernel code. 
Just as we wouldn't meld a bike rack to our car (well maybe some people would do that). Kernel modules are pieces of code that can be loaded and unloaded into the kernel on demand. 
They allow us to extend the functionality of the kernel without actually adding to the core kernel code. We can also add modules and not have to reboot the system (in most cases).


View a list of currently loaded modules:
""lsmod""


Load a module:
""sudo modprobe bluetooth""

Modprobe loads tries the module from ""/lib/modules/(kernel version)/kernel/drivers. 
Kernel modules may also have dependencies, modprobe loads our module dependencies if they are not already loaded. 


Remove a module:
""sudo modprobe -r bluetooth""


Load on bootup:
You can also load modules during system boot, instead of temporarily loading them with modprobe (which will be unloaded when you reboot). 
Just modify the ""/etc/modprobe.d"" directory and add a configuration file in it like so:

pete@icebox:~$ /etc/modprobe.d/peanutbutter.conf
options peanut_butter type=almond

A bit of a outlandish example, but if you had a module named peanut_butter and you wanted to add a kernel parameter for type=almond, you can have it load on startup using this configuration file. 
Also note that kernel modules have their own kernel parameters so you'll want to read about the module specifically to find out more.


Do not load on bootup:
You can also make sure a module does not load on bootup by adding a configuration file like so:

pete@icebox:~$ /etc/modprobe.d/peanutbutter.conf
blacklist peanut_butter
        ";
     
    }

    //Init Lessons

    public void lessonOneHundredTwentyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The main purpose of init is to start and stop essential processes on the system. 
There are three major implementations of init in Linux, System V, Upstart and systemd. 

In this lesson, we're going to go over the most traditional version of init, System V init or Sys V (pronounced as 'System Five'). 


To find out if you are using the Sys V init implementation, if you have an /etc/inittab file you are most likely running Sys V. 

Sys V starts and stops processes sequentially, 
so let's say if you wanted to start up a service named foo-a, well before foo-b can work, you have to make sure foo-a is already running. 
Sys V does that with scripts, these scripts start and stop services for us, 
we can write our own scripts or most of the time use the ones that are already built in the operating system and are used to load essential services.


The pros of using this implementation of init, is that it's relatively easy to solve dependencies, 
since you know foo-a comes before foo-b, however performance isn't great because usually one thing is starting or stopping at a time. 


When using Sys V, the state of the machine is defined by runlevels which are set from 0 to 6. 
These different modes will vary depending on the distribution, but most of the time will look like the following: 

0: Shutdown
1: Single User Mode
2: Multiuser mode without networking
3: Multiuser mode with networking
4: Unused
5: Multiuser mode with networking and GUI
6: Reboot


When your system starts up, it looks to see what runlevel you are in and executes scripts located inside that runlevel configuration. 
The scripts are located in ""/etc/rc.d/rc[runlevel number].d/"" or ""/etc/init.d"". 

Scripts that start with S(start) or K(kill) will run on startup and shutdown, respectively. 
The numbers next to these characters are the sequence they run in. 

For example:
""pete@icebox:/etc/rc.d/rc0.d$ ls""
K10updates  K80openvpn        


We see when we switch to runlevel 0 or shutdown mode, our machine will try to run a script to kill the updates services and then openvpn. 
To find out what runlevel your machine is booting into, you can see the default runlevel in the /etc/inittab file. 
You can also change your default runlevel in this file as well. 


One thing to note, System V is slowly getting replaced, maybe not today, or even years from now. 
However, you may see runlevels come up in other init implementations, this is primarily to support those services that are only started or stopped using System V init scripts.
        ";
     
    }

    public void lessonOneHundredTwentyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
There are many command line tools you can use to manage Sys V services. 


List services:
""service --status-all""


Start a service:
""sudo service networking start""


Stop a service:
""sudo service networking stop""


Restart a service:
""sudo service networking restart""


These commands aren't specific to Sys V init systems, you can use these commands to manage Upstart services as well. 
Since Linux is trying to move away from the more traditional Sys V init scripts, there are still things in place to help that transition.
        ";
     
    }

    public void lessonOneHundredTwentyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Upstart was developed by Canonical, so it was the init implementation on Ubuntu for a while.

However on modern Ubuntu installations systemd is now used. 
Upstart was created to improve upon the issues with Sys V, such as the strict startup processes, blocking of tasks, etc. 
Upstart's event and job driven model allow it to respond to events as they happen. 

To find out if you are using Upstart, if you have a /usr/share/upstart directory that's a pretty good indicator. 


Jobs are the actions that Upstart performs and events are messages that are received from other processes to trigger jobs. 
To see a list of jobs and their configuration:

""ls /etc/init""
acpid.conf                   mountnfs.sh.conf
alsa-restore.conf            mtab.sh.conf
alsa-state.conf              networking.conf
alsa-store.conf              network-interface.conf
anacron.conf                 network-interface-container.conf

Inside these job configurations, it'll include information on how to start jobs and when to start jobs.


For example, in the networking.conf file, it could say something as simple as:
start on runlevel [235]
stop on runlevel [0]

This means that it will start setting up networking on runlevel 2, 3 or 5 and will stop networking on runlevel 0. 
There are many ways to write the configuration file and you'll discover that when you look at the different job configurations available. 


The way that Upstart works is that: 

1- First, it loads up the job configurations from /etc/init
2- Once a startup event occurs, it will run jobs triggered by that event.
3- These jobs will make new events and then those events will trigger more jobs
4- Upstart continues to do this until it completes all the necessary jobs
        ";
 
    }

    public void lessonOneHundredTwentyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Upstart can trigger a lot of events and jobs to run, unfortunately there is no easy way to see where an event or job originated, 
so you'll have to poke around the job configurations in /etc/init. 

Most of the time, you won't ever need to look at the Upstart job configuration files, but you will want to control some specific jobs more easily. 
There are a lot of useful commands you can use in an Upstart system. 


View jobs:
initctl list

shutdown stop/waiting
console stop/waiting
...


You'll see a list of Upstart jobs with different statuses applied to them. 
In each line, the job name is the first value and the second field (before the /) is actually the goal of the job, the third value (after the /) is the current status. 
So we see that our shutdown job eventually wants to stop, but it is currently in a state of waiting. The job status and goals will change as you start or stop jobs. 


View specific job:
initctl status networking
networking start/running


We won't get into the details of how to write an Upstart job configuration, however we already know that jobs are stopped, started and restarted in these configurations. 
These jobs also emit events, so they can start other jobs. 
We'll go through the manual commands of the Upstart operation, but if you are curious, you should dig into the .conf files in more depth.


Manually start a job:
sudo initctl start networking


Manually stop a job:
sudo initctl stop networking


Manually restart a job:
sudo initctl restart networking


Manually emit an event:
sudo initctl emit some_event
        ";
        
    }

    public void lessonOneHundredTwentyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Systemd is slowly becoming the emerging standard for init. 
If you have a /usr/lib/systemd directory, you're most likely using systemd.


Systemd uses goals to get your system up and running. 
Basically you have a target that you want to achieve and this target also has dependencies that we need to achieve. 
Systemd is extremely flexible and robust, it does not follow a strict sequence to get processes started. Here's what happens during the typical systemd boot:

1- First, systemd loads it's configuration files, usually located in /etc/systemd/system or /usr/lib/systemd/system
2- Then it determines its boot goal, which is usually default.target
3- Systemd figures out the dependencies of the boot target and activates them


Similar to Sys V runlevels, systemd boots into different targets:

1- poweroff.target - shutdown system
2- rescue.target - single user mode
3- multi-user.target - multiuser with networking
4- graphical.target - multiuser with networking and GUI
5- reboot.target - restart

The default boot goal of default.target usually points to the graphical.target. 


The main object that systemd works with are known as units. 
Systemd doesn't just stop and start services, it can mount filesystems, monitor your network sockets, etc 
and because of that robustness it has different types of units it operates. The most common units are:

1- Service units - these are the services we've been starting and stopping, these unit files end in .service
2- Mount units - These mount filesystems, these unit files end in .mount
3- Target units - These group together other units, the files end in .target


For example, let's say we boot into our default.target, well this target groups together the networking.service unit, crond.service unit, etc, 
so once we activate a single unit, everything below that unit gets activated as well.       
        ";
 
    }

    public void lessonOneHundredTwentySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We won't get into the details of writing systemd unit files. 
We will however go over a brief overview of a unit file and how to manually control units. 

Here is a basic service unit file: foobar.service
[Unit]
Description=My Foobar
Before=bar.target

[Service]
ExecStart=/usr/bin/foobar

[Install]
WantedBy=multi-user.target


This is a simple service target, at the beginning of the file we see a section for [Unit], 
this allows us to give our unit file a description as well as control the ordering of when to activate the unit. 

The next portion is the [Service] section, under here we can start, stop or reload a service. 
And the [Install] section is used for dependency. 

This is only the tip of the iceberg for writing systemd files, so I implore you to read up on the subject if you want to know more. 


Now, let's get into some commands you can use with systemd units: 

List units:
""systemctl list-units""

View status of unit:
""systemctl status networking.service""

Start a service:
""sudo systemctl start networking.service""

Stop a service:
""sudo systemctl stop networking.service""

Restart a service:
""sudo systemctl restart networking.service""

Enable a unit:
""sudo systemctl enable networking.service""

Disable a unit:
""sudo systemctl disable networking.service""

Again, you have yet to see how much depth systemd gets into, so read up on it if you want to learn more.        
        ";
        
    }

    public void lessonOneHundredTwentySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=false;
        lessonOneHundredTwentyTwoButton.IsVisible=false;
        lessonOneHundredTwentyThreeButton.IsVisible=false;
        lessonOneHundredTwentyFourButton.IsVisible=false;
        lessonOneHundredTwentyFiveButton.IsVisible=false;
        lessonOneHundredTwentySixButton.IsVisible=false;
        lessonOneHundredTwentySevenButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Hard to believe we haven't actually discussed ways to control your system state through the command line, 
but when talking about init, we not only talk about the modes that get us starting our system, but also the ones that stop our system.


To shutdown your system:
""sudo shutdown -h now""
This will halt the system (power it off), you must also specify a time when you want this to take place. 


You can add a time in minutes that will shutdown the system in that amount of time:
""sudo shutdown -h +2""
This will shutdown your system in two minutes.


You can also restart with the shutdown command: 
""sudo shutdown -r now""


Or just use the reboot command:
""sudo reboot""
        
        ";
        
    }

    //Process Utilization Lessons

    public void lessonOneHundredTwentyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In this course, we'll go over how to read and analyze the resource utilization on your system, this lesson shows some great tools to use when you need to track what a process is doing. 


top:
We've discussed top before, but we're going to dig into the specifics of what it's actually displaying. 
Remember top is the tool we used to get a real time view of the system utilization by our processes:

top - 18:06:26 up 6 days,  4:07,  2 users,  load average: 0.92, 0.62, 0.59
Tasks: 389 total,   1 running, 387 sleeping,   0 stopped,   1 zombie
%Cpu(s):  1.8 us,  0.4 sy,  0.0 ni, 97.6 id,  0.1 wa,  0.0 hi,  0.0 si,  0.0 st
KiB Mem:  32870888 total, 27467976 used,  5402912 free,   518808 buffers
KiB Swap: 33480700 total,    39892 used, 33440808 free. 19454152 cached Mem

  PID USER      PR  NI    VIRT    RES    SHR S  %CPU %MEM     TIME+ COMMAND                             
 6675 patty    20   0 1731472 520960  30876 S   8.3  1.6 160:24.79 chrome                             
 6926 patty    20   0  935888 163456  25576 S   4.3  0.5   5:28.13 chrome 

Let's go over what this output means, you don't have to memorize this, but come back to this when you need a reference.


1st line: This is the same information you would see if you ran the uptime command (more to come)

The fields are from left to right:
1- Current time
2- How long the system has been running
3- How many users are currently logged on
4- System load average (more to come)


2nd line: Tasks that are running, sleeping, stopped and zombied


3rd line: Cpu information:

1- us: user CPU time - Percentage of CPU time spent running users’ processes that aren’t niced.
2- sy: system CPU time - Percentage of CPU time spent running the kernel and kernel processes
3- ni: nice CPU time - Percentage of CPU time spent running niced processes
4- id: CPU idle time - Percentage of CPU time that is spent idle
5- wa: I/O wait - Percentage of CPU time that is spent waiting for I/O. If this value is low, the problem probably isn’t disk or network I/O
6- hi: hardware interrupts - Percentage of CPU time spent serving hardware interrupts
7- si: software interrupts - Percentage of CPU time spent serving software interrupts
8- st: steal time - If you are running virtual machines, this is the percentage of CPU time that was stolen from you for other tasks


4th and 5th line: Memory Usage and Swap Usage


Processes List that are Currently in Use:

1- PID: Id of the process
2- USER: user that is the owner of the process
3- PR: Priority of process
4- NI: The nice value
5- VIRT: Virtual memory used by the process
6- RES: Physical memory used from the process
7- SHR: Shared memory of the process
8- S: Indicates the status of the process: S=sleep, R=running, Z=zombie,D=uninterruptible,T=stopped
9- %CPU - this is the percent of CPU used by this process
10- %MEM - percentage of RAM used by this process
11- TIME+ - total time of activity of this process
12- COMMAND - name of the process


You can also specify a process ID if you just want to track certain processes:
""top -p 1""
        ";
  
    }

    public void lessonOneHundredTwentyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's say you plugged in a USB drive and starting working on some files, once you were done, you go and unmount the USB device and you're getting an error ""Device or Resource Busy"". 
How would you find out which files in the USB drive are still in use? There are actually two tools you can use for this: 

lsof:
Remember files aren't just text files, images, etc, they are everything on the system, disks, pipes, network sockets, devices, etc. To see what is in use by a process, you can use the lsof command (short for ""list open files"") 
this will show you a list of all the open files and their associated process. 

""lsof""
COMMAND    PID  USER   FD   TYPE DEVICE SIZE/OFF NODE NAME
lxsession 1491 pete  cwd    DIR    8,6     4096  131 .
update-no 1796 pete  cwd    DIR    8,6     4096  131 .
nm-applet 1804 pete  cwd    DIR    8,6     4096  131 .
indicator 1809 pete  cwd    DIR    8,6     4096  131 .
xterm     2205 pete  cwd    DIR    8,6     4096  131 .
bash      2207 pete  cwd    DIR    8,6     4096  131 .
lsof      5914 pete  cwd    DIR    8,6     4096  131 .
lsof      5915 pete  cwd    DIR    8,6     4096  131 .

Now I can see what processes are currently holding the device/file open. In our USB example, you can also kill these processes so we can unmount this pesky drive.


fuser:
Another way to track a process is the fuser command (short for ""file user""), this will show you information about the process that is using the file or the file user. 

""fuser -v""
                     USER        PID ACCESS COMMAND
/home/pete:         pete  1491 ..c.. lxsession
                     pete  1796 ..c.. update-notifier
                     pete  1804 ..c.. nm-applet
                     pete  1809 ..c.. indicator-power
                     pete  2205 ..c.. xterm
                     pete  2207 ..c.. bash

We can see which processes are currently using our /home/pete directory. 
The lsof and fuser tools are very similar, familiarize yourself with these tools and try using them next time you need to track a file or process down.
        ";
       
    }

    public void lessonOneHundredThirtyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
You may have heard of the terms single-threaded and multi-threaded processes. 
Threads are very similar to processes, in that they are used to execute the same program, they are often referred to as lightweight processes. 
If a process has one thread it is single-threaded and if a process has more than one thread it is multi-threaded. 
However, all processes have at least one thread. 


Processes operate with their own isolated system resources, 
however threads can share these resources among each other easily, 
making it easier for them to communicate among each other and at times it is more efficient to have a multi-threaded application than a multi-process application.


Basically, let's say you open up LibreOffice Writer and Chrome, each is it's own separate process. 
Now you go inside Writer and start editing text, when you edit the text it gets automatically saved. 
These two parallel ""lightweight processes"" of saving and editing are threads. 


To view process threads, you can use: 

""ps m""
  PID TTY      STAT   TIME COMMAND
 2207 pts/2    -      0:01 bash
    - -        Ss     0:01 -
 5252 pts/2    -      0:00 ps m
    - -        R+     0:00 -


The processes are denoted with each PID and underneath the processes are their threads (denoted by a --). 
So you can see that the processes above are both single-threaded.        
        ";
        
    }

    public void lessonOneHundredThirtyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's go over a useful command, ""uptime"".


""uptime""
 17:23:35 up 1 day,  5:59,  2 users,  load average: 0.00, 0.02, 0.05


We talked about uptime in the first lesson of this course, but we haven't gone over the load average field.

Load averages are good way to see the CPU load on your system. 
These numbers represent the average CPU load in 1, 5, and 15 minute intervals. 
What do I mean by CPU load, the CPU load is the average number of processes that are waiting to be executed by the CPU.


Let's say you have a single-core CPU, think of this core as a single lane in traffic. 
If it's rush hour on the freeway, this lane is gonna be really busy and traffic is gonna be at 100% or a load of 1. 
Now the traffic has become so bad, it's backing up the freeway and getting the regular roads busy by twice the amount of cars, 
we can say that your load is 200% or a load of 2. 

Now let's say it clears up a bit and there are only half as many cars on the freeway lane, 
we can say the load of the lane is 0.5. When traffic is non-existent and we can get home quicker, the load should ideally be very low, like 2am traffic low. 
The cars in this case are processes and these processes are just waiting to get off the freeway and get home.


Now just because you have a load average of 1 doesn't mean your computer is slogging around. 
Most modern machines these days have multiple cores. 
If you had a quad core processor (4 cores) and your load average is 1, it's really just affecting 25% of your CPU. 
Think of each core as a lane in traffic. You can view the amount of cores you have on your system with ""cat /proc/cpuinfo"".


When observing load average, you have to take the number of cores into account, 
if you find that your machine is always using an above average load, there could something wrong going on.
        ";
        
    }

    public void lessonOneHundredThirtyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We can also monitor CPU usage as well as monitor disk usage with a handy tool known as ""iostat""


""iostat""
Linux 3.13.0-39-lowlatency (icebox)     01/28/2016      _i686_  (1 CPU)

avg-cpu:  %user   %nice %system %iowait  %steal   %idle
           0.13    0.03    0.50    0.01    0.00   99.33

Device:            tps    kB_read/s    kB_wrtn/s    kB_read    kB_wrtn
sda               0.17         3.49         1.92     385106     212417


The first part is the CPU information:

1- %user - Show the percentage of CPU utilization that occurred while executing at the user level (application)
2- %nice - Show the percentage of CPU utilization that occurred while executing at the user level with nice priority.user CPU utilization with nice priorities
3- %system - Show the percentage of CPU utilization that occurred while executing at the system level (kernel).
4- %iowait - Show the percentage of time that the CPU or CPUs were idle during which the system had an outstanding disk I/O request.
5- %steal - Show the percentage of time spent in involuntary wait by the virtual CPU or CPUs while the hypervisor was servicing another virtual processor.
6- %idle - Show the percentage of time that the CPU or CPUs were idle and the system did not have an outstanding disk I/O request.


The second part is the disk utilization:

1- tps - Indicate the number of transfers per second that were issued to the device. 
A transfer is an I/O request to the device. Multiple logical requests can be combined into a single I/O request to the device. A transfer is of indeterminate size.

2- kB_read/s - Indicate the amount of data read from the device expressed in kilobytes per second.
3- kB_wrtn/s - Indicate the amount of data written to the device expressed in kilobytes per second.
4- kB_read - The total number of kilobytes read.
5- kB_wrtn - The total number of kilobytes written.
        ";
        
    }

    public void lessonOneHundredThirtyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In addition to CPU monitoring and I/O monitoring you can monitor your memory usage with ""vmstat""

""vmstat""
procs -----------memory---------- ---swap-- -----io---- -system-- ------cpu-----
 r  b   swpd   free   buff  cache   si   so    bi    bo   in   cs us sy id wa st
 1  0      0 396528  38816 384036    0    0     4     2   38   79  0  0 99  0  0


The fields are as follows:
procs:
1- r - Number of processes for run time
2- b - Number of processes in uninterruptible sleep


memory:
1- swpd - Amount of virtual memory used
2- free - Amount of free memory
3- buff - Amount of memory used as buffers
4- cache - Amount of memory used as cache


swap:
1- si - Amount of memory swapped in from disk
2- so - Amount of memory swapped out to disk


io:
1- bi - Amount of blocks received in from a block device
2- bo - Amount of blocks sent out to a block device


system:
1- in - Number of interrupts per second
2- cs - Number of context switches per second


cpu:
1- us - Time spent in user time
2- sy - Time spent in kernel time
3- id - Time spent idle
4- wa - Time spent waiting for IO
        ";
        
    }

    public void lessonOneHundredThirtyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
These monitoring tools are good to look at when your machine is having issues, 
but what about machines that are having issues when you aren't looking. 

For those, you'll need to use a continuous monitoring tool, something that will collect, 
report and save your system activity information. In this lesson we will go over a great tool to use ""sar""


Installing sar:
Sar is a tool that is used to do historical analysis on your system, 
first make sure you have it installed by installing the sysstat package ""sudo apt install sysstat"".


Setting up data collection:
Usually once you install sysstat, your system will automatically start collecting data, 
if it doesn't you can enable it by modifying the ENABLED field in /etc/default/sysstat.


Using sar:
""sudo sar -q""
This command will list the details from the start of the day.


""sudo sar -r""
This will list the details of memory usage from the start of the day.


""sudo sar -P""
This will list the details of CPU usage. 


To see a view of a different day, you can go into /var/log/sysstat/saXX where XX is the day you want to view. 
""sar -q /var/log/sysstat/sa02""
        ";
  
    }

    public void lessonOneHundredThirtyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=false;
        lessonOneHundredTwentyNineButton.IsVisible=false;
        lessonOneHundredThirtyButton.IsVisible=false;
        lessonOneHundredThirtyOneButton.IsVisible=false;
        lessonOneHundredThirtyTwoButton.IsVisible=false;
        lessonOneHundredThirtyThreeButton.IsVisible=false;
        lessonOneHundredThirtyFourButton.IsVisible=false;
        lessonOneHundredThirtyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Although we have been talking about resource utilization, 
I think this would be a good point to mention a neat tool in Linux that is used to schedule tasks using cron. 
There is a service that runs programs for you at whatever time you schedule. 
This is a really useful if you have a script you want to run once a day that needs to execute something for you.


For example, let's say I have a script located in /home/pete/scripts/change_wallpaper. 
I use this script every morning to change the picture I use for my wallpaper, but each morning I have to manually execute this script. 
Instead what I can do is create a cron job that executes my script through cron. I can specify the time I want this cron job to run and execute my script. 

""30 08 * * * /home/pete/scripts/change_wallpaper""


The fields are as follows from left to right:
1- Minute - (0-59)
2- Hour - (0-23)
3- Day of the month - (1-31)
4- Month - (1-12)
5- Day of the week - (0-7). 0 and 7 are denoted as Sunday


The asterisk in the field means to match every value. 
So in my above example, I want this to run every day in every month at 8:30am.


To create a cronjob, just edit the crontab file:
""crontab -e""
        ";
        
    }

    //Logging Lessons

    public void lessonOneHundredThirtySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=false;
        lessonOneHundredThirtySevenButton.IsVisible=false;
        lessonOneHundredThirtyEightButton.IsVisible=false;
        lessonOneHundredThirtyNineButton.IsVisible=false;
        lessonOneHundredFortyButton.IsVisible=false;
        lessonOneHundredFortyOneButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The services, kernel, daemons, etc on your system are constantly doing something, 
this data is actually sent to be saved on your system in the form of logs. 

This allows us to have a human readable journal of the events that are happening on our system. 
This data is usually kept in the /var directory, the /var directory is where we keep our variable data, such as logs!


How are these messages even getting received on your system? 
There is a service called syslog that sends this information to the system logger. 


Syslog actually contains many components, one of the important ones is a daemon running called syslogd (newer Linux distributions use rsyslogd), 
that waits for event messages to occur and filter the ones it wants to know about, and depending on what it's supposed to do with that message, 
it will send it to a file, your console or do nothing with it.


You would think that this system logger is the centralized place to manage logs, but unfortunately it's not. 
You'll see many applications that write their own logging rules and generate different log files, 
however in general the format of logs should include a timestamp and the event details. 


Here is an example of a line from syslog:
""less /var/log/syslog""
Jan 27 07:41:32 icebox anacron[4650]: Job `cron.weekly' started


Here we can see that at Jan 27 07:41:32 our cron service ran the cron.weekly job. 
You can view all the event messages that syslog collects with in the /var/log/syslog file.       
        ";
        
    }

    public void lessonOneHundredThirtySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=false;
        lessonOneHundredThirtySevenButton.IsVisible=false;
        lessonOneHundredThirtyEightButton.IsVisible=false;
        lessonOneHundredThirtyNineButton.IsVisible=false;
        lessonOneHundredFortyButton.IsVisible=false;
        lessonOneHundredFortyOneButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The syslog service manages and sends logs to the system logger. 
Rsyslog is an advanced version of syslog, most Linux distributions should be using this new version. 
The output of all the logs the syslog service collects can be found at /var/log/syslog (every message except auth messages).


To find out what files are maintained by our system logger, look at the configuration files in /etc/rsyslog.d:
""less /etc/rsyslog.d/50-default.conf""
# First some standard log files.  Log by facility.
#
auth,authpriv.*                 /var/log/auth.log
*.*;auth,authpriv.none          -/var/log/syslog
#cron.*                         /var/log/cron.log
#daemon.*                       -/var/log/daemon.log
kern.*                          -/var/log/kern.log
#lpr.*                          -/var/log/lpr.log
mail.*                          -/var/log/mail.log
#user.*                         -/var/log/user.log


These rules to log files are denoted by the selector on the left column and the action on the right column. 
The action tells us where to send the log information, in a file, console, etc. 

Remember not every application and service uses rsyslog to manage their logs, 
so if you want to know specifically what is logged you'll have to look inside this directory.


Let's actually see logging in action, you can manually send a log with the logger command:
""logger -s Hello""


Now look inside your /var/log/syslog and you should see this entry in your logs!       
        ";
        
    }

    public void lessonOneHundredThirtyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=false;
        lessonOneHundredThirtySevenButton.IsVisible=false;
        lessonOneHundredThirtyEightButton.IsVisible=false;
        lessonOneHundredThirtyNineButton.IsVisible=false;
        lessonOneHundredFortyButton.IsVisible=false;
        lessonOneHundredFortyOneButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
There are many log files you can view on your system, many important ones can be found under /var/log.
We won't go through them all, but we'll discuss a couple of the major ones. 


There are two general log files you can view to get a glimpse of what your system is doing:
""/var/log/messages""


This log contains all non-critical and non-debug messages, includes messages logged during bootup (dmesg), auth, cron, daemon, etc.
Very useful to get a glimpse of how your machine is acting. 

""/var/log/syslog""

This logs everything except auth messages, it's extremely useful for debugging errors on your machine. 


These two logs should be more than enough when troubleshooting issues with your system, 
However, if you just want to view a specific log component, there are also separate logs for those as well.
        ";
        
    }

    public void lessonOneHundredThirtyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=false;
        lessonOneHundredThirtySevenButton.IsVisible=false;
        lessonOneHundredThirtyEightButton.IsVisible=false;
        lessonOneHundredThirtyNineButton.IsVisible=false;
        lessonOneHundredFortyButton.IsVisible=false;
        lessonOneHundredFortyOneButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
""/var/log/dmesg""
On boot-time your system logs information about the kernel ring buffer. 
This shows us information about hardware drivers, kernel information and status during bootup and more. 

This log file can be found at /var/log/dmesg and gets reset on every boot, 
you may not actually see any use in it now, but if you were to ever have issues with something during bootup or a hardware issue, 
dmesg is the best place to look. You can also view this log using the dmesg command. 



""/var/log/kern.log""
Another log you can use to view kernel information is the /var/log/kern.log file, 
this logs the kernel information and events on your system, it also logs dmesg output.       
        ";
        
    }
    
    public void lessonOneHundredFortyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=false;
        lessonOneHundredThirtySevenButton.IsVisible=false;
        lessonOneHundredThirtyEightButton.IsVisible=false;
        lessonOneHundredThirtyNineButton.IsVisible=false;
        lessonOneHundredFortyButton.IsVisible=false;
        lessonOneHundredFortyOneButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Authentication logging can be very useful to look at if you are having issues logging in. 

""/var/log/auth.log""
This contains system authorization logs, such as user login and the authentication method used. 


Sample snippet:
Jan 31 10:37:50 icebox pkexec: pam_unix(polkit-1:session): session opened for user root by (uid=1000)
        ";
        
    }

    public void lessonOneHundredFortyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=false;
        lessonOneHundredThirtySevenButton.IsVisible=false;
        lessonOneHundredThirtyEightButton.IsVisible=false;
        lessonOneHundredThirtyNineButton.IsVisible=false;
        lessonOneHundredFortyButton.IsVisible=false;
        lessonOneHundredFortyOneButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Log files generate lots of data and they store this data on your hard disks, 
however there are lots of issues with this, for the most part we just want to be able to see newer logs, we also want to manage our disk space efficiently, 
so how do we do all of this? The answer is with logrotate. 


The logrotate utility does log management for us. 
It has a configuration file that allows us to specify how many and what logs to keep, how to compress our logs to save space and more. 
The logrotate tool is usually run out of cron once a day and the configuration files can be found in /etc/logrotate.d. 


There are other logrotating tools you can use to manage your logs, but logrotate is the most common one.        
        ";
       
    }

    //Networking Lessons

    public void lessonOneHundredFortyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=false;
        lessonOneHundredFortyThreeButton.IsVisible=false;
        lessonOneHundredFortyFourButton.IsVisible=false;
        lessonOneHundredFortyFiveButton.IsVisible=false;
        lessonOneHundredFortySixButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
You usually are not the only computer on your network, this is especially the case if you're working in a commercial environment. 
When we want to transfer data from one machine to another, sometimes it maybe easier to connect a USB drive and manually copy them. 
But for the most part, if you're working with machines on the same network, the way to transfer data is through network file sharing. 


In this course we'll go over a couple of different methods to copy data to and from different machines on your network. 
We'll discuss some simple file copies, then we'll talk about mounting entire directories on your machine that act as a separate drive. 


One simple file sharing tool is the ""scp"" command. 
The scp command stands for secure copy, it works exactly the way the cp command does, 
but allows you to copy from one host over to another host on the same network. 
It works via ssh so all your actions are using the same authentication and security as ssh. 


To copy a file over from local host to a remote host:
""scp myfile.txt username@remotehost.com:/remote/directory""


To copy a file from a remote host to your local host:
""scp username@remotehost.com:/remote/directory/myfile.txt /local/directory""


To copy over a directory from your local host to a remote host:
""scp -r mydir username@remotehost.com:/remote/directory""
        ";
        
    }

    public void lessonOneHundredFortyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=false;
        lessonOneHundredFortyThreeButton.IsVisible=false;
        lessonOneHundredFortyFourButton.IsVisible=false;
        lessonOneHundredFortyFiveButton.IsVisible=false;
        lessonOneHundredFortySixButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Another tool used to copy data from different hosts is rsync (short for remote synchronization). 
Rsync is very similar to scp, but it does have a major difference. 
Rsync uses a special algorithm that checks in advanced if there is already data that you are copying to and will only copy over the differences. 

For example, let's say that you were copying over a file and your network got interrupted, therefore your copy stopped midway. 
Instead of re-copying everything from the beginning, rsync will only copy over the parts that didn't get copied. 


It also verifies the integrity of a file you are copying over with checksums. 
These small optimizations allow greater file transfer flexibility and makes rsync ideal for directory synchronization remotely and locally, data backups, large data transfers and more.


Some commonly-used rsync options:

1- v - verbose output
2- r - recursive into directories
3- h - human readable output
4- z - compressed for easier transfer, great for slow connections


Copy/sync files on the same host:
""rsync -zvr /my/local/directory/one /my/local/directory/two""


Copy/sync files to local host from a remote host:
""rsync /local/directory username@remotehost.com:/remote/directory""


Copy/sync files to a remote host from a local host:
""rsync username@remotehost.com:/remote/directory /local/directory""
        ";
        
    }

    public void lessonOneHundredFortyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=false;
        lessonOneHundredFortyThreeButton.IsVisible=false;
        lessonOneHundredFortyFourButton.IsVisible=false;
        lessonOneHundredFortyFiveButton.IsVisible=false;
        lessonOneHundredFortySixButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Python has a super useful tool for serving files over HTTP. 
This is great if you just want to create a quick network share that other machines on your network can access. 
To do that just go to the directory you want to share and run:

""python -m SimpleHTTPServer""


This sets up a basic webserver that you can access via the localhost address. 
So grab the IP address of the machine you ran this on and then on another machine access it in the browser with: http://IP_ADDRESS:8000. 
On your own machine, you can view the files available by typing: http://localhost:8000 in your web browser.


You can also do this with node or if you are running Python 3, the syntax will be a little bit different.       
        ";
      
    }

    public void lessonOneHundredFortyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=false;
        lessonOneHundredFortyThreeButton.IsVisible=false;
        lessonOneHundredFortyFourButton.IsVisible=false;
        lessonOneHundredFortyFiveButton.IsVisible=false;
        lessonOneHundredFortySixButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The most standard network file share for Linux is NFS (Network File System), 
NFS allows a server to share directories and files with one or more clients over the network. 


We won't get into the details of how to create an NFS server as it can get complex, however we will discuss setting up NFS clients.


Setting up NFS client:
""sudo service nfsclient start""
""sudo mount server:/directory /mount_directory""


Automounting:
Let's say you use the NFS server quite often and you want to keep it permanently mounted, normally you think you'd edit the /etc/fstab file, 
but you may not always get a connection to the server and that can cause issues on bootup. 

Instead what you want to do is setup automounting so that you can connect to the NFS server when you need to. 
This is done with the <b>automount</b> tool or in recent versions of Linux ""amd"". 
When a file is accessed in a specified directory, automount will look up the remote server and automatically mount it.
        ";
        
    }

    public void lessonOneHundredFortySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=false;
        lessonOneHundredFortyThreeButton.IsVisible=false;
        lessonOneHundredFortyFourButton.IsVisible=false;
        lessonOneHundredFortyFiveButton.IsVisible=false;
        lessonOneHundredFortySixButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
In the early days of computing, it became necessary for Windows machines to share files with Linux machines, 
thus the Server Message Block (SMB) protocol was born. SMB was used for sharing files between Windows operating systems (Mac also has file sharing with SMB) 
and then it was later cleaned up and optimized in the form of the Common Internet File System (CIFS) protocol. 


Samba is what we call the Linux utilities to work with CIFS on Linux. 
In addition to file sharing, you can also share resources like printers. 


Create a network share with Samba:
Let's go through the basic steps to create a network share that a Windows machine can access:


Install Samba:
""sudo apt update""
""sudo apt install samba""


Setup smb.conf:
The configuration file for Samba is found at /etc/samba/smb.conf, this file should tell the system what directories should be shared, their access permissions, and more options. 
The default smb.conf comes with lots of commented code already and you can use those as an example to write your own configurations.

""sudo vi /etc/samba/smb.conf""


Setup up a password for Samba:
""sudo smbpasswd -a [username]""


Create a shared directory:
""mkdir /my/directory/to/share""


Restart the Samba service:
""sudo service smbd restart""


Accessing a Samba share via Windows:
In Windows, just type in the network connection in the run prompt: \\HOST\sharename.


Accessing a Samba/Windows share via Linux:
""smbclient //HOST/directory -U user""


The Samba package includes a command line tool called ""smbclient"" that you can use to access any Windows or Samba server. 
Once you're connected to the share you can navigate and transfer files.


Attach a Samba share to your system:
Instead of transferring files one by one, you can just mount the network share on your system.

""sudo mount -t cifs servername:directory mountpount -o user=username,pass=password""
        ";
        
    }

    public void lessonOneHundredFortySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's look at a typical home network, you have a few different components. 


1- ISP - Your internet service provider, the company you pay to get Internet at your house.

2- Router - The router allows each machine on your network to connect to the Internet. 
In most modern routers, you can connect via wireless or an Ethernet cable.

3- WAN - Wide Area Network, this is what we call the network that encompasses everything between your router and a wider network such the Internet.

4- WLAN - Wireless Local Area Network, this is the network between your router and any wireless devices you may have such as laptops.

5- LAN - Local Area Network, this is the network between your router and any wired devices such as Desktop PCs.

6- Hosts - Each machine on a network is known as a host.


The data and information that gets transmitted through networks are known as packets and by the end of the Networking Nomad section, 
you'll understand in detail how a packet travels to and from hosts.       
        ";
        
    }

    public void lessonOneHundredFortyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before we can look at some practical networking stuff, we have to go over some boring jargon that you've probably heard of before. 
The OSI (Open Systems Interconnection) model is a theoretical model of networking. 
This model shows us how a packet traverses through a network in seven different layers. 

I won't get into specifics of this model, since most of these networking courses will be focused on the TCP/IP model, 
but it should be mentioned that such a theoretical networking model exists and has actually played a large part in the TCP/IP networking model that we use today.
        ";
        
    }

    public void lessonOneHundredFortyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The OSI model gave birth to what eventually became the TCP/IP model and this model is actually what the Internet is based off of. 
It is the actual implementation of networking. The TCP/IP model uses the TCP/IP protocol suite, which we just commonly refer to as TCP/IP. 
These protocols work together to specify how data should be gathered, addressed, transmitted and routed through a network. 
Using the TCP/IP model, we can see how these protocols are used to show the breakdown of how a packet travels through the network.



Application Layer:
The top layer of the TCP/IP model. 
It determines how your computer's programs (such as your web browser) interface with the transport layer services to view the data that gets sent or received.

This layer uses:
1- HTTP (Hypertext Transfer Protocol) - used for the webpages on the Internet.
2- SMTP (Simple Mail Transfer Protocol) - electronic mail (email) transmission



Transport Layer:
How data will be transmitted, includes checking the correct ports, the integrity of the data, and basically delivering our packets.

This layer uses:
1- TCP (Transmission Control Protocol) - reliable data delivery
2- UDP (User Datagram Protocol) - unreliable data delivery



Network Layer:
This layers specifies how to move packets between hosts and across networks.

This layer uses:
1- IP (Internet Protocol) - Helps route packets from one machine to another.
20 ICMP (Internet Control Message Protocol) - Helps tell us what is going on, such as error messages and debugging information.



Link Layer:
This layer specifies how to send data across a physical piece of hardware. Such as data travelling through Ethernet, fiber, etc.



The lists above of protocols each layer uses is not extensive and you'll encounter many other protocols that come into play.


In the following lessons, we will dive through each of these layers and discuss how our packet traverses through the network in the eyes of the TCP/IP model 
(there are many perspectives on how a packet travels across networks, we won't look at them all, but be aware that they exist).
        ";
        
    }

    public void lessonOneHundredFiftyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before we jump into seeing how a packet moves across a network, we have to familiarize ourselves with some terminology. 
When you mail a letter, you must know who it is being sent to and where it is coming from. 
Packets need the same information, our hosts and other hosts are identified using MAC (media access control) addresses and IP addresses, to make it easier on us humans we use hostnames to identify a host.


MAC Addresses:
A MAC address is a unique identifier used as a hardware address. 
This address will never change. 

When you want to get access to the Internet, your machine needs to have a device called a network interface card. 
This network adapter has its own hardware address that's used to identify your machine. 
A MAC address for an Ethernet device looks something like this 00:C4:B5:45:B2:43. 
MAC addresses are given to network adapters when they are manufactured. 
Each manufacturer has an organizationally unique identifier (OUI) to identify them as the manufacturer. 
This OUI is denoted by the first 3 bytes of the MAC address. For example, Dell has 00-14-22, so a network adapter from Dell could have a MAC address like: 00-14-22-34-B2-C2. 


IP Addresses:
An IP Address is used to identify a device on a network, they are hardware independent and can vary in syntax depending on if you are using IPv4 or IPv6 (more on this later). 
For now we'll assume you are using IPv4, so a typical IP address would look like: 10.24.12.4. 

IP addresses are used with the software side of networking. Anytime a system is connected to the Internet it should have an IP address. 
They can also change if your network changes and are unique to the entire Internet (this isn't always the case once we learn about NAT). 


Remember it takes both software and hardware to move packets across networks, so we have two identifiers for each, MAC (hardware) and IP (software).


Hostnames:
One last way to identify your machines is through hostname. 
Hostnames take your IP address and allow you to tie that address to a human readable name. 
Instead of remembering 192.12.41.4 you can just remember myhost.com.       
        ";
        
    }

    public void lessonOneHundredFiftyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's say I wanted to send an email to Patty. We'll go through each of the TCP/IP layers to see this in action. 


Remember that packets are used to transmit data across networks, a packet consists of a header and payload. 
The header contains information about where the packet is going and where it came from. 
The payload is the actual data that is being transferred. 
As our packet traverses the network, each layer adds a bit of information to the header of the packet. 
Also keep in mind that different layers use a different term for our ""packet"". 
In the transport layer we essentially encapsulate our data in a segment and in the link layer we refer to this as a frame, but just know that packet can be used in regards to the same thing.



First we start off in the application layer. 
When we send our email through our email client, the application layer will encapsulate this data. 
The application layer talks to the transport layer through a specified port and through this port it sends its data. 
We want to send an email through the application layer protocol SMTP (simple mail transfer protocol). 
The data is sent through our transport protocol which opens a connection to this port (port 25 is used for SMTP), 
so we get this data sent through this port and that data is sent to the Transport layer to be encapsulated into segments.
        ";
        
    }

    public void lessonOneHundredFiftyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The transports layer helps us transfer our data in a way networks can read it. 
It breaks our data into chunks that will be transported and put back together in the correct order. 
These chunks are known as segments. Segments make it easier to transport data across networks. 


Ports:
Even though we know where we are sending our data via IP addresses, they aren't specific enough to send our data to a certain processes or services. 
Services such as HTTP use a communication channel via ports. 
If we want to send webpage data, we need to send it over the HTTP port (port 80). 
In addition to forming segments, the transport layer will also attach the source and destination ports to the segment, so when the receiver gets the final packet it will know what port to use. 


UDP:
There are two popular transport protocols UDP and TCP. 
We'll briefly discuss UDP and spend most of our time on TCP, since it's the most commonly used.

UDP is not a reliable method of transporting data, in fact it doesn't really care if you get all of your original data. 
This may sound terrible, but it does have its uses, such as for media streaming, it's ok if you lose some frames in return you get your data a little faster. 


TCP:
TCP provides a reliable connection-oriented stream of data. 
TCP uses ports to send data to and from hosts. An application opens up a connection from one port on its host to another port on a remote host. 
In order to establish the connection, we use the TCP handshake. 

1- The client (connecting process) sends a SYN segment to the server to request a connection
2- Server sends the client a SYN-ACK segment to acknowledge the client's connection request
3- Client sends an ACK to the server to acknowledge the server's connection request


Once this connection is established, data can be exchanged over a TCP connection. 
The data is sent over in different segments and are tracked with TCP sequence numbers so they can be arranged in the correct order when they are delivered. 
In our email example, the transport layer attaches the destination port (25) to the source port of the source host.
        ";
        
    }

    public void lessonOneHundredFiftyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The Network layer determines the routing of our packets from our source host to a destination host. 
Fortunately in our example, our packet is only traveling within the same network, but the Internet is made up of many networks. 
These smaller networks that make up the Internet are known as subnets. 
All subnets connect to each other in some way, which is why we are able to get to www.google.com even though it's on its own network. 
I won't go into detail as we have a whole course dedicated to subnets, but for now in regards to our Network layer, know that the IP addresses define the rules to travel to different subnets. 



In the network layer, 
it receives the segment coming from the transport layer and encapsulates this segment in an IP packet then attaches the IP address of the source host and the IP address of the destination host to the packet header. 
So at this point, our packet has information about where it is going and where it came from. Now it sends our packet to the physical hardware layer.
        ";
        
    }

    public void lessonOneHundredFiftyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
At the bottom of the TCP/IP model sits the Link Layer. 
This layer is the hardware specific layer.


In the link layer, our packet is encapsulated once more into something called a frame. 
The frame header attaches the source and destination MAC addresses of our hosts, checksums and packet separators so that the receiver can tell when a packet ends.


Fortunately we are on the same network, so our packet won't have to travel too far. 
First, the link layer attaches my source MAC address to the frame header, but it needs to know Patty's MAC address as well. 
How does it know that and how do I find it since it's not on the Internet? We use ARP!


ARP (Address Resolution Protocol):

ARP finds the MAC address associated with an IP address. 
ARP is used within the same network. 
If Patty was not on the same network, we would use a routing system to determine the next router that would receive the packet and once we were on the same network, we could use ARP. 

Once we are on the same network, systems first use the ARP look-up table that stores information about what IP addresses are associated with what MAC address. 
If the value is not there, then ARP is used. Then the system will send a broadcast message to the network using the ARP protocol to find out which host has IP 10.10.1.4. 
A broadcast message is a special message that is sent to all hosts on a network (aptly named for sending a broadcast). 
Any machine with the requested IP address will reply with an ARP packet containing the IP address and the MAC address.

Now that we have all the necessary data we need, IP address and MAC addresses, our link layer forwards this frame through our network interface card, out to the next device and finds Patty's network. 
This step is a little more complex than how I just explained it, but we will discuss more details in the Routing course.


And there it is a simple (or not so simple) packet traversal down the TCP/IP layer. 
Keep in mind that packets don't travel in a one way fashion like this. 
We haven't even gotten to Patty's network yet! When travelling through networks, it requires going through the TCP/IP model at least twice before any data is sent or received. 
In reality, the way this packet looks would be something like this: 



Packet Traversal:

1- Pete sends Patty an email: this data gets sent to the transport layer.

2- The transport layer encapsulates the data into a TCP or UDP header to form a segment, the segment attaches the destination and source TCP or UDP port, then the segment is sent to the network layer.

3- The network layer encapsulates the TCP segment inside an IP packet, it attaches the source and destination IP address. Then routes the packet to the link layer.

4- The packet then reaches Pete's physical hardware and gets encapsulated in a frame. The source and destination MAC address get added to the frame.

5- Patty's receives this data frame through her physical layer and checks each frame for data integrity, then de-encapsulates the frame contents and sends the IP packet to the network layer.

6- The network layer reads the packet to find the source and destination IP that was previously attached. 
It checks if its IP is the same as the destination IP, which it is! It de-encapsulates the packet and sends the segment to the transport layer.

7- The transport layer de-encapsulates the segments, checks the TCP or UDP port numbers and makes a connection to the application layer based on those port numbers.

8- The application layer receives the data from the transport layer on the port that was specified and presents it to Patty in the form of the final email message
        ";
        
    }

    public void lessonOneHundredFiftyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=false;
        lessonOneHundredFortyEightButton.IsVisible=false;
        lessonOneHundredFortyNineButton.IsVisible=false;
        lessonOneHundredFiftyButton.IsVisible=false;
        lessonOneHundredFiftyOneButton.IsVisible=false;
        lessonOneHundredFiftyTwoButton.IsVisible=false;
        lessonOneHundredFiftyThreeButton.IsVisible=false;
        lessonOneHundredFiftyFourButton.IsVisible=false;
        lessonOneHundredFiftyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
An important networking concept that we did not go over yet is DHCP (Dynamic Host Configuration Protocol)


DHCP assigns IP addresses, subnet masks and gateways to our machines. 
For example, let's say you have a cell phone and you want to get a cell phone number to start talking to people. 
You have to call up your phone carrier and they will give you a number. 
As long as your pay your bills you can keep using your phone. 
DHCP is the phone carrier in this case, it gives you an IP address so that you can talk to other IP addresses. 
You are also leased an IP address, these last for a certain period of time, then will get renewed depending on how you have your lease settings. 


DHCP is great for many reasons, it allows a network administrator to not worry about assigning IP addresses and it also prevents them from setting up duplicate IP addresses. 
Every physical network should have its own DHCP server so that a host can request an IP address. In a regular home setting, the router usually acts as the DHCP server.


The way DHCP gets all your dynamic host information is:

1- DHCP DISCOVER - This message is broadcasted to search for a DHCP server.
2- DHCP OFFER - The DHCP server in the network replies with an offer message. The offer contains a packet with DHCP lease time, subnet mask, IP address, etc.
3- DHCP REQUEST - The client sends out another broadcast to let all DHCP servers know which offer it accepted.
4- DHCP ACK - Acknowledgement is sent by the server.


DHCP gets more involved than this, but this is the gist of it.       
        ";
        
    }

    //Subnetting Lessons

    public void lessonOneHundredFiftySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
So we know that network hosts have a unique address they can be found at. 
These addresses are known as IP addresses. An IPv4 address looks something like this:
""204.23.124.23""


This address actually contains two parts, the network portion that tells us know network it's on and the host portion that tells us which host on that network it is. 
For this course we will mostly be discussing IPv4 addresses, which are what you commonly will see when referring to IP addresses. 


An IP address is separated into octets by the periods. 
So there are 4 octets in an IPv4 address. 
If you know a bit of computer science, an octet is 8 bits and 8 bits actually equal 1 byte, so we also refer to an IPv4 address as having 4 bytes. 
We use bits frequently when dealing with subnets and IP addresses.


You can view your IP address with the ifconfig -a command:

""ifconfig -a""
eth0      Link encap:Ethernet  HWaddr 1d:3a:32:24:4d:ce  
          inet addr:192.168.1.129  Bcast:192.168.1.255  Mask:255.255.255.0
          inet6 addr: fd60::21c:29ff:fe63:5cdc/64 Scope:Link


As you can see my IPv4 address is: 192.168.1.129       
        ";
 
    }

    public void lessonOneHundredFiftySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
How can I tell if I'm on the same network as Patty? 
Well we can just look at the subnet short for subnetwork. 
A subnet is a group of hosts with IP addresses that are similar in a certain way. 
These hosts usually are in a proximate location from each other and you can easily send data to and from hosts on the same subnet. 
Think about it as sending mail in the same zip code, it's a lot easier than sending mail to a different state. 


For example, all hosts with an IP address that starts with 123.45.67 would be on the same subnet. 
My host has an IP of 123.45.67.8 and Patty's has an IP of 123.45.67.9. 
The common numbers are my network prefix and the 8 and 9 are our hosts, therefore my network is the same as Patty's. 
A subnet is divided into a network prefix, such as 123.45.67.0 and a subnet mask.


Subnet Masks:
Subnet masks determine what part of your IP address is the network portion and what part is the host portion. 

A typical subnet mask can look something like this:

""255.255.255.0""

The 255 portion is actually our mask. 
To make this a little easier to understand, remember how we refer to each octet as 8 bits? In computer science a bit is denoted by a 0 or a 1 in binary form. 
When binary numbers are used, 1 means on and 0 means off. So what does 8 0's or 1's equal?


Punch into Google ""binary to decimal calculator"" and convert 11111111 into a decimal form. 
What do you get? 255! So an octet ranges from 0 to 255. 
So if we had a subnet mask of 255.255.255.0, and an IP address of 192.168.1.0, how many hosts are on that subnet? 
We'll find out the answer to that in our subnet math lesson.


Also when we talk about our subnet, we commonly denote it by the network prefix followed by the subnet mask:
""123.234.0.0/255.255.0.0""


Why?:
Why on earth do we make subnets? 
Subnetting is used to segment networks and control the flow of traffic within that network. 
So a host on one subnet can’t interact with another host on a different subnet. 


But wait a minute, what if I want to connect to other hosts like yahoo.com? 
Then you need to connect subnets together. 
To connect subnets you just need to find the hosts that are connected to more than one subnet. 
For example, if my host at 192.168.1.129 is connected to a local network of 192.168.1.129/24 it can reach any hosts on that network. 
To reach hosts on the rest of the Internet, it needs to communicate through the router. 
Traditionally, on most networks with a subnet mask of 255.255.255.0, the router is usually at address 1 of the subnet, so 192.168.1.1. 
Now that router will have a port that connects it to another subnet (more in the Routing course). 
Certain IP addresses (private networks) are not visible to the internet, and we have things like NAT in place (more on this later).
        ";
 
    }

    public void lessonOneHundredFiftyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Ok, we know that subnet masks are important to figure out how many hosts we can have on our subnet. 
So how many hosts would that be? 


Let's say I have an IP address of ""192.168.1.0"" and a subnet mask of ""255.255.255.0"", now let's line up these numbers in binary form. For now use an online calculator to convert these values from decimal to binary.

192.168.1.165  = 11000000.10101000.00000001.10100101
255.255.255.0  = 11111111.11111111.11111111.00000000


The IP address is masked by our subnet mask, when you see a 1, it is masked and we pretend like we don't see it. 
So the only possible hosts we can have are from the 00000000 region. 
Remember 11111111 in binary form equals 255, we also account 0 as a host number, so there are 256 possible options. 
However, it may look like we have 256 possible options, but we actually subtract 2 hosts because we have to account for the broadcast address and the subnet address, leaving us with 254 possible hosts on our subnet. 
So we know that we can have hosts with IP addresses ranging from 192.168.1.1 - 192.168.1.254.
        ";
 
    }

    public void lessonOneHundredFiftyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
I hate to have to add this section, in the real world you would most likely never have to do subnet math by hand, 
however if you were getting interviewed on this, you'll have to know how to convert to and from binary form for subnetting. 

Luckily there are some arithmetic cheats you can memorize. 


First memorize your base-2 calculations, just do it:

2^1 = 2
2^2 = 4
2^3 = 8
2^4 = 16
2^5 = 32
2^6 = 64
2^7 = 128
2^8 = 256
2^9 = 512
2^10 = 1024
2^11 = 2048
2^12 = 4096


Decimal to Binary Chart:
1   1  1  1  1 1 1 1
128 64 32 16 8 4 2 1

There are lots of reasons why the following chart looks the way it does, if you're curious how it works there are lots of resources online.


Ok, got these memorized? Let's do a quick decimal to binary conversion:

Convert 192.168.23.43 to Binary:
Remember: 128 / 64 / 32 / 16 / 8 / 4 / 2 / 1

Let's walk through converting the first octet to binary and you'll understand how the rest works.

Can you subtract 192 - 128? Yes, so the first bit is 1
192 - 128 = 64, the next number in the chart is 64, can you subtract 64 - 64? Yes, so the second bit is 1
We've run out of numbers to subtract from, so our binary form of 192 is 11000000


Convert Binary 11000000 to Decimal:
For binary to decimal conversion you add up the numbers that have a 1, so:
128 + 64 + 0 + 0 + 0 + 0 + 0 + 0 = 192!       
        ";
 
    }

    public void lessonOneHundredSixtyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
CIDR (classless inter-domain routing) is used to represent a subnet mask in a more compact way. 
You may see subnets notated in CIDR notation, 
where a subnet such as the 10.42.3.0/255.255.255.0 is written as 10.42.3.0/24 which just means it includes both the subnet prefix and the subnet mask.


Remember an IP address consists of 4 bytes or 32 bits, CIDR indicates the amount of bits used as the network prefix. 
So 123.12.24.0/23 means that the first 23 bits are used. Well what does that mean? How many hosts is that? 


A simple trick is to subtract the total of bits an IP address can have (32) from the CIDR address (23), 
so that leaves 9 bits, 2^9 = 512, but we have to remove 2 addresses (subnet address and broadcast address) so we have 510 usable hosts.
        ";
 
    }

    public void lessonOneHundredSixtyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We've brought up NAT (network address translation) before but didn't touch upon it, when we are working on our network, 
does that mean that the Internet can see our IP address? Not quite.


NAT makes a device like our router act as an intermediary between the Internet and private network. 
So only a single, unique IP address is required to represent an entire group of computers.


Think of NAT is like a receptionist in a large office, if someone wants to contact you, they only know the number to the whole office, 
the receptionist would then have to look for your extension number and forward the call to you.


How does it work?:
 
A simple case would look like this:

1- Patty wants to connect to www.google.com, so her machine sends this request through the router
2- The router takes that request and opens its own connection to google.com, then it sends Patty's request once it makes a connection
3- The router is the intermediary between Patty and www.google.com. Google doesn't know about Patty instead all it can see is the router.


NAT and packet routing in general can get pretty ugly, but we won't dive into the specifics.     
        ";
 
    }

    public void lessonOneHundredSixtyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=false;
        lessonOneHundredFiftySevenButton.IsVisible=false;
        lessonOneHundredFiftyEightButton.IsVisible=false;
        lessonOneHundredFiftyNineButton.IsVisible=false;
        lessonOneHundredSixtyButton.IsVisible=false;
        lessonOneHundredSixtyOneButton.IsVisible=false;
        lessonOneHundredSixtyTwoButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We've heard the term IPv6 here and there, but what is it? 
Every device that connects to the Internet gets it's own IP address, well that happens to be a finite number that we are soon approaching in this digital age. 

IPv6 was created to allow us to connect more hosts to the Internet, it comes with more IP improvements however, it's adoption is quite slow. 
It isn't meant to replace IPv4, they are meant to complement each other. 
The two IP protocols are very similar and if you know IPv4 you'll understand IPv6, the major difference is the way the address is written. 
Here is what a typical IPv6 address looks like:

""2dde:1235:1256:3:200:f8ed:fe23:59cf""
        ";
 
    }

    //Routing Lessons

    public void lessonOneHundredSixtyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We've used this term router before, hopefully you know what one is, since you probably have one in your home. 
A router enables machines on a network to communicate with each other as well as other networks. 

On a typical router, you will have LAN ports, 
that allow your machines to connect to the same local area network and you will also have an Internet uplink port that connects you to the Internet, 
sometimes you'll see this port being labelled as WAN, because it is essentially connecting you to a wider network. 

When we do any sort of networking activity, it has to go through the router. 
The router decides where our network packets go and which ones come in. 
It routes our packets between multiple networks to get from it's source host to it's destination host. 



How does a router work?:
Think about routing the same way as mail delivery, we have an address we want to send a letter to, 
when we send it off to the post office, they get the letter and see, oh this is going to California, 
I'll put it on the truck going to California (I honestly have no idea how the postal system works). 

The letter then gets sent to San Francisco, inside San Francisco there are different zip codes, and then in those zip codes there are smaller address codes, 
until finally someone is able to deliver your letter to the address you wanted. 
On the other hand, if you already lived in San Francisco and in the same zipcode, 
the mail deliverer will probably know exactly where the letter has to go to without handing it off to anyone else. 

When we route packets, they use similar address ""routes"", such as to get to network A, send these packets to network B. When we don't have a route set for that, we have a default route that our packets will use. 
These routes are set on a routing table that our system uses to navigate us across networks.


Hops:
As packets move across networks, they travel in hops, a hop is how we roughly measure the distance that the packet must travel to get from the source to the destination. 
Let's say to I have two routers connecting host A to host B, so therefore we say there are two hops between host A and host B. 
Each hop is a intermediate device like the routers that we must pass through.


Understanding the basic difference between Switching, Routing & Flooding?:
Packet SWITCHING is basically receiving, processing and forwarding data to the destination device.
ROUTING is a process of creating the routing table, so that we can do SWITCHING better.
Before routing, FLOODING was used. If a router don't know which way to send a packet than every incoming packet is sent through every outgoing link except the one it arrived on.        
        ";
 
    }

    public void lessonOneHundredSixtyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Look at your machine's routing table:

""sudo route -n""
Kernel IP routing table
Destination     Gateway         Genmask         Flags Metric Ref    Use Iface
0.0.0.0         192.168.224.2   0.0.0.0         UG    0      0        0 eth0
192.168.224.0   0.0.0.0         255.255.255.0   U     1      0        0 eth0


Destination:
In the first field, we have a destination IP address of 192.168.224.0, this says that any packet that tries to go to this network, 
goes out through my Ethernet cable (eth0). If I was 192.168.224.5 and wanted to get to 192.168.224.7, 
I would just use the network interface eth0 directly. 


Notice that we have addresses of ""0.0.0.0"" this means that no address is specified or it's unknown. 
So if for example, I wanted to send a packet to IP address 151.123.43.6, our routing table doesn't know where that goes, 
so it denotes it as 0.0.0.0 and therefore routes our packet to the Gateway.


Gateway:
If we are sending a packet that is not on the same network, it will be sent to this Gateway address. 
Which is aptly named as being a Gateway to another network.


Genmask:
This is the subnet mask, used to figure out what IP addresses match what destination. 


Flags:
UG - Network is Up and is a Gateway
U - Network is Up


Iface:
This is the interface that our packet will be going out of, eth0 usually stands for the first Ethernet device on your system.        
        ";
 
    }

    public void lessonOneHundredSixtyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's look at how a packet travels within it's local network:

1- First the local machine will compare the destination IP address to see if it's in the same subnet by looking at its subnet mask.

2- When packets are sent they need to have a source MAC address, destination MAC address, source IP address and destination IP address, 
at this point we do not know the destination MAC address.

3- To get to the destination host, we use ARP to broadcast a request on the local network to find the MAC address of the destination host.

4- Now the packet can be successfully sent!



Let's see how a packet travels outside it's network:

1- First the local machine will compare the destination IP address, since it's outside of our network, it does not see the MAC address of the destination host. 
And we can't use ARP because the ARP request is a broadcast to locally connected hosts.

2- So our packet now looks at the routing table, it doesn't know the address of the destination IP, so it sends it out to the default gateway (another router). 
So now our packet contains our source IP, destination IP and source MAC, however we don't have a destination MAC. 
Remember MAC addresses are only reached through the same network. 
So what does it do? It sends an ARP request to get the MAC address of the default gateway.


3- The router looks at the packet and confirms the destination MAC address, but it's not the final destination IP address, 
so it keeps looking at the routing table to forward the packet to another IP address that can help the packet move along to its destination. 
Everytime the packet moves, it strips the old source and destination MAC address and updates the packet with the new source and destination MAC addresses.

4- Once the packet gets forwarded to the same network, we use ARP to find the final destination MAC address.

5- During this process, our packet doesn't change the source or destination IP address.
        ";
 
    }

    public void lessonOneHundredSixtySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
It would be a pain to have to manually configure routes on a routing table for every device on your network, so instead we use what are known as routing protocols. 
Routing protocols are used to help our system adapt to network changes, it learns of different routes, 
builds them in the routing table and then routes our packets through that way. 

There are two primary routing protocol types, distance vector protocols and link state protocols.


Convergence:
Before we talk about the protocols, we should go over a term using in routing known as convergence. 

When using routing protocols, routers communicate with other routers to collect and exchange information about the network. 
When they agree on how a network should look, every routing table maps out the complete topology of the network, thus ""converging"". 

When something occurs in the network topology, the convergence will temporarily break until all routers are aware of this change.       
        ";
 
    }

    public void lessonOneHundredSixtySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Distance vector protocols determine the path of other networks using the hop count a packet takes across the network. 
If network A was 3 hops away and network B was next to network A, then we assume it must be 4 hops away. 
In distance vector protocols, the next route would be the one with the least amount of hops.


Distance vector protocols are great for small networks, 
when networks start to scale it takes longer for the routers to converge because it periodically sends the entire routing table out to every router. 

Another downside to distance vector protocols is efficiency, it chooses routes that are closer in hops, but it may not always choose the most efficient route.


One of the common distance vector protocols is RIP (Routing Information Protocol), it broadcasts the routing table to every router in the network every 30 seconds. 
For a large network, this can take some serious juice to pull off, because of that RIP limits it's hop count to 15.        
        ";
 
    }

    public void lessonOneHundredSixtyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Link state protocols are great for large scale networks, they are more complex than distance vector protocols, 
however a large upside is their ability to converge quickly, 
this is because instead of periodically sending out the whole routing table, they only send updates to neighboring routes. 

They use a different algorithm to calculate the shortest path first and construct their network topology in the form of a graph to show which routers are connected to other routers.


One of the common link state protocols is OSPF (Open Shortest Path First), it only updates the routing tables if there was a network change. 
It doesn't have a hop limit.       
        ";
 
    }

    public void lessonOneHundredSixtyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=false;
        lessonOneHundredSixtyFourButton.IsVisible=false;
        lessonOneHundredSixtyFiveButton.IsVisible=false;
        lessonOneHundredSixtySixButton.IsVisible=false;
        lessonOneHundredSixtySevenButton.IsVisible=false;
        lessonOneHundredSixtyEightButton.IsVisible=false;
        lessonOneHundredSixtyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The last important protocol we'll discuss is BGP, BGP is basically how the Internet runs. 
It's used to collect and exchange routing information among autonomous systems. 
Think of an autonomous system as an Internet service provider, a company, university, any organization, etc. 

Without BGP, these systems would not know how to talk to each other, they would just be siloed off. 
Instead of routing inside these autonomous systems, BGP routes between them.



Let's say you were on your home network and I'm working from Starbucks, 
I want to be able to communicate with you, so I send an email and the network packet travels through Starbuck's network, 
it bounces around there and goes through the routing tables in Starbuck's network until it finally reaches a point at the border of the Starbucks network and passes it to a Border Gateway router. 

This router contains the information for my packet to leave the Starbucks network and traverse other networks.        
        ";
 
    }

    //Network Config Lessons

    public void lessonOneHundredSeventyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=false;
        lessonOneHundredSeventyOneButton.IsVisible=false;
        lessonOneHundredSeventyTwoButton.IsVisible=false;
        lessonOneHundredSeventyThreeButton.IsVisible=false;
        lessonOneHundredSeventyFourButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
A network interface is how the kernel links up the software side of networking to the hardware side. 
We've already seen an example of this: 

""ifconfig -a""
eth0      Link encap:Ethernet  HWaddr 1d:3a:32:24:4d:ce  
          inet addr:192.168.1.129  Bcast:192.168.1.255  Mask:255.255.255.0
          inet6 addr: fd60::21c:29ff:fe63:5cdc/64 Scope:Link



The ifconfig command:
The ""ifconfig"" tool allows us to configure our network interfaces, if we don't have any network interfaces set up, the kernel's device drivers and the network won't know how to talk to each other. 
Ifconfig runs on bootup and configures our interfaces through config files, but we can also manually modify them. 
The output of ifconfig shows the interface name on the left side and the right side shows detailed information. 

You'll most commonly see interfaces named eth0 (first Ethernet card in the machine), wlan0 (wireless interface), lo (loopback interface). 
The loopback interface is used to represent your computer, it just loops you back to yourself. 
This is good for debugging or connecting to servers running locally. 


The status of interfaces, can be up or down, as you can guess if you wanted to ""turn off"" an interface you can set it to go down. 
The fields you'll probably look at the most in the ifconfig output is the HWaddr (MAC address of the interface), inet address (IPv4 address) and inet6 (IPv6 address). 
Of course you can see that the subnet mask and broadcast address are there as well. 
You can also view interface information at /etc/network/interfaces.


To create an interface and bring it up:
""ifconfig eth0 192.168.2.1 netmask 255.255.255.0 up""

This assigns an IP address and netmask to the eth0 interface and also turns it up.


To bring up or down an interface:

""ifup eth0""
""ifdown eth0""


The ip command:
The ""ip"" command also allows us to manipulate the networking stack of a system. 
Depending on the distribution you are using it may be the preferred method of manipulating your network settings. 


Here are some examples of its use:

To show interface information for all interfaces:
""ip link show""


To show the statistics of an interface:
""ip -s link show eth0""


To show ip addresses allocated to interfaces:
""ip address show""


To bring interfaces up and down:
""ip link set eth0 up""
""ip link set eth0 down""


To add an IP address to an interface:
""ip address add 192.168.1.1/24 dev eth0""
        ";
 
    }

    public void lessonOneHundredSeventyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=false;
        lessonOneHundredSeventyOneButton.IsVisible=false;
        lessonOneHundredSeventyTwoButton.IsVisible=false;
        lessonOneHundredSeventyThreeButton.IsVisible=false;
        lessonOneHundredSeventyFourButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We've already discussed viewing our routing tables with the route command, if you wanted to add or remove routes you can do so manually.


Add a new route:
""sudo route add -net 192.168.2.1/23 gw 10.11.12.3""


Delete a route:
""sudo route del -net 192.168.2.1/23""



You can also perform these changes with the ""ip"" command:

To add a route:
""ip route add 192.168.2.1/23 via 10.11.12.3""


To delete a route:
""ip route delete 192.168.2.1/23 via 10.11.12.3""
or
""ip route delete 192.168.2.1/23""
        ";
 
    }

    public void lessonOneHundredSeventyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=false;
        lessonOneHundredSeventyOneButton.IsVisible=false;
        lessonOneHundredSeventyTwoButton.IsVisible=false;
        lessonOneHundredSeventyThreeButton.IsVisible=false;
        lessonOneHundredSeventyFourButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We've discussed DHCP before and most often you will never need to statically set your IP addresses, subnet masks, etc. 
Instead you'll be using DHCP! The dhclient starts up on boot and gets a list of network interfaces from the dhclient.conf file. 
For each interface listed it tries to configure the interface using the DHCP protocol.


In the dhclient.leases file, dhclient keeps track of a list of leases across system reboots, 
after reading dhclient.conf, the dhclient.leases file is read to let it know what leases it's already assigned.


To obtain a fresh IP:
""sudo dhclient""
        ";
 
    }

    public void lessonOneHundredSeventyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=false;
        lessonOneHundredSeventyOneButton.IsVisible=false;
        lessonOneHundredSeventyTwoButton.IsVisible=false;
        lessonOneHundredSeventyThreeButton.IsVisible=false;
        lessonOneHundredSeventyFourButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Of course if you wanted to have your system's networking up and running automatically there is something already in place for that. 
Most distributions utilize the NetworkManager daemon to configure their networks automatically. 


You'll notice NetworkManager in the form of an applet somewhere on your desktop taskbar if you are using a GUI. 
As you can see it manages your network's hardware and connection information. For instance on startup, 
NetworkManager will gather network hardware information, search for connections to wireless, wired, etc. and then activates it.


There are also command-line tools to interact with NetworkManager:

nm-tool:
nm-tools reports NetworkManager's state and it's devices

""nm-tool""
NetworkManager Tool

State: connected (global)

- Device: eth0  [Wired connection 1] -------------------------------------------
  Type:              Wired
  Driver:            pcnet32
  State:             connected
  Default:           yes
  HW Address:        12:3D:45:56:7D:CC

  Capabilities:
    Carrier Detect:  yes

  Wired Properties
    Carrier:         on

  IPv4 Settings:
    Address:         192.168.22.1
    Prefix:          24 (255.255.255.0)
    Gateway:         192.168.22.2

    DNS:             192.168.22.2



nmcli:
The nmcli command allows you to control and modify NetworkManager, see the manpage for more details.        
        ";
 
    }

    public void lessonOneHundredSeventyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=false;
        lessonOneHundredSeventyOneButton.IsVisible=false;
        lessonOneHundredSeventyTwoButton.IsVisible=false;
        lessonOneHundredSeventyThreeButton.IsVisible=false;
        lessonOneHundredSeventyFourButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Remember when we lookup a MAC address with ARP, it first checks the locally stored ARP cache on our system, 
you can actually view this cache: 

""arp""
Address                  HWtype  HWaddress           Flags Mask            Iface
192.168.22.1            ether   00:12:24:fc:12:cc   C                     eth0
192.168.22.254          ether   00:12:45:f2:84:64   C                     eth0


The ARP cache is actually empty when a machine boots up, it gets populated as packets are being sent to other hosts. 
If we send a packet to a destination that isn't in the ARP cache, the following happens:


1- The source host creates the Ethernet frame with an ARP request packet
2- The source host broadcasts this frame to the entire network
3- If one of the hosts on the network knows the correct MAC address, it will send a reply packet and frame containing the MAC address
4- The source host adds the IP to MAC address mapping to the ARP cache and then proceeds with sending the packet


You can also view your arp cache via the ip command:

""ip neighbour show""
        ";
 
    }

    //TroubleShooting Lessons

    public void lessonOneHundredSeventyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=false;
        lessonOneHundredSeventySixButton.IsVisible=false;
        lessonOneHundredSeventySevenButton.IsVisible=false;
        lessonOneHundredSeventyEightButton.IsVisible=false;
        lessonOneHundredSeventyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The Internet Control Message Protocol (ICMP) is part of the TCP/IP protocol suite, 
it used to send updates and error messages and is an extremely useful protocol used for debugging network issues such as a failed packet delivery.


Each ICMP message contains a type, code and checksum field. 
The type field is the type of ICMP message, 
the code is a sub-type and describes more information about the message and the checksum is used to detect any issues with the integrity of the message.


Let's look at some common ICMP Types:

Type 0 - Echo Reply
Type 3 - Destination Unreachable
Type 8 - Echo Request
Type 11 - Time Exceeded


When a packet can't get to a destination, Type 3 ICMP message is generated, within Type 3 there are 16 code values that will further describe why it can't get to the destination: 

Code 0 - Network Unreachable
Code 1 - Host Unreachable
etc..etc..


These messages will make more sense as we use some network troubleshooting tools.        
        ";
 
    }
    
    public void lessonOneHundredSeventySixButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=false;
        lessonOneHundredSeventySixButton.IsVisible=false;
        lessonOneHundredSeventySevenButton.IsVisible=false;
        lessonOneHundredSeventyEightButton.IsVisible=false;
        lessonOneHundredSeventyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
One of the most simplest networking tools <b>ping</b>, it's used to test whether or not a packet can reach a host. 
It works by sending ICMP echo request (Type 8) packets to the destination host and waits for an ICMP echo reply (Type 0). 
Ping is successful when a host sends out the request packet and receives a response from the target. 

Let's look at an example: 

""ping -c 3 www.google.com""
PING www.google.com (74.125.239.112) 56(84) bytes of data.
64 bytes from nuq05s01-in-f16.1e100.net (74.125.239.112): icmp_seq=1 ttl=128 time=29.0 ms
64 bytes from nuq05s01-in-f16.1e100.net (74.125.239.112): icmp_seq=2 ttl=128 time=23.7 ms
64 bytes from nuq05s01-in-f16.1e100.net (74.125.239.112): icmp_seq=3 ttl=128 time=15.1 ms


In this example, we are using ping to check if we can get to www.google.com. 
The -c flag (count) is used to stop sending echo request packets after the count has been reached. 


The first part says that we are sending 64-byte packets to 74.125.239.112 (google.com) and the rest show us the details of the trip. 
By default it sends a packet per second.


icmp_seq:
The icmp_seq field is used to show the sequence number of packets sent, so in this case, 
I sent out 3 packets and we can see that 3 packets made it back. If you do a ping and you get some sequence numbers missing, 
that means that some connectivity issue is happening and not all your packets are getting through. 

If the sequence number is out of order, your connection is probably very slow as your packets are exceeding the one second default. 


ttl:
The Time To Live (ttl) field is used as a hop counter, as you make hops, it decrements the counter by one and once the hop counter reaches 0, our packet dies. 
This is meant to give the packet a lifespan, we don't want our packets travelling around forever.


time:
The roundtrip time it took from you sending the echo request packet to getting an echo reply.        
        ";
 
    }

    public void lessonOneHundredSeventySevenButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=false;
        lessonOneHundredSeventySixButton.IsVisible=false;
        lessonOneHundredSeventySevenButton.IsVisible=false;
        lessonOneHundredSeventyEightButton.IsVisible=false;
        lessonOneHundredSeventyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The traceroute command is used to see how packets are getting routed. 
It works by sending packets with increasing TTL values, starting with 1. 
So the first router gets the packet, and it decrements the TTL value by one, thus dropping the packet. 

The router sends back an ICMP Time Exceeded message back to us. 
And then the next packet gets a TTL of 2, so it makes it past the first router, 
but when it gets to the second router the TTL is 0 and it returns another ICMP Time Exceeded message. 

Traceroute works this way because as it sends and drops packets it is build a list of routers that the packets traverse, 
until it finally gets to its destination and gets an ICMP Echo Reply message. 



Here's a little snippet of a traceroute: 

""traceroute google.com""
traceroute to google.com (216.58.216.174), 30 hops max, 60 byte packets                          
 1  192.168.4.254 (192.168.4.254)  0.028 ms  0.009 ms  0.008 ms                                  
 2  100.64.1.113 (100.64.1.113)  1.227 ms  1.226 ms 0.920 ms
 3  100.64.0.20 (100.64.0.20)  1.501 ms 1.556 ms  0.855 ms                                                                                 


Each line is a router or machine that is between me and my target. 
It shows the name of the target and its IP address and the last three columns correspond to the round-trip time of a packet to get to that router. 
By default, we send three packets along the route.       
        ";
 
    }

    public void lessonOneHundredSeventyEightButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=false;
        lessonOneHundredSeventySixButton.IsVisible=false;
        lessonOneHundredSeventySevenButton.IsVisible=false;
        lessonOneHundredSeventyEightButton.IsVisible=false;
        lessonOneHundredSeventyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Well Known Ports:
We've discussed data transmission through ports on our machine, let's look at some well known ports.


You can get a list of well-known ports by looking at the file /etc/services: 

ftp             21/tcp
ssh             22/tcp
smtp            25/tcp 
domain          53/tcp  # DNS
http            80/tcp
https           443/tcp
..etc..

The first column is the name of the service, then the port number and the transport layer protocol it uses.


netstat:
An extremely useful tool to get detailed information about your network is ""netstat"". 
Netstat displays various network related information such network connections, routing tables, information about network interfaces and more, 
it's the swiss army knife of networking tools. 
We will focus mostly on one feature netstat has and that's the status of network connections. 

Before we look at an example, let's talk about sockets and ports first. 
A socket is an interface that allows programs to send and receive data while a port is used to identify which application should send or receive data. 
The socket address is the combination of the IP address and port. Every connection between a host and destination requires a unique socket. 
For example, HTTP is a service that runs on port 80, however we can have many HTTP connections and to maintain each connection a socket gets created per connection.

""netstat -at""
Active Internet connections (servers and established)
Proto Recv-Q Send-Q Local Address           Foreign Address         State      
tcp        0      0 icebox:domain           *:*                     LISTEN     
tcp        0      0 localhost:ipp           *:*                     LISTEN     
tcp        0      0 icebox.lan:44468        124.28.28.50:http       TIME_WAIT  
tcp        0      0 icebox.lan:34751        124.28.29.50:http       TIME_WAIT  
tcp        0      0 icebox.lan:34604        economy.canonical.:http TIME_WAIT  
tcp6       0      0 ip6-localhost:ipp       [::]:*                  LISTEN     
tcp6       1      0 ip6-localhost:35094     ip6-localhost:ipp       CLOSE_WAIT 
tcp6       0      0 ip6-localhost:ipp       ip6-localhost:35094     FIN_WAIT2

The netstat -a command shows the listening and non-listening sockets for network connections, the -t flag shows only tcp connections. 


The columns are as follows from left to right:

1- Proto: Protocol used, TCP or UDP.
2- Recv-Q: Data that is queued to be received
3- Send-Q: Data that is queued to be sent
4- Local Address: Locally connected host
5- Foreign Address: Remotely connected host
6- State: The state of the socket


See the manpage for a list of socket states, but here are a few:

1- LISTENING: The socket is listening for incoming connections, remember when we make a TCP connection our destination has to be listening for us before we can connect.
2- SYN_SENT: The socket is actively attempting to establish a connection.
3- ESTABLISHED: The socket has an established connection
4- CLOSE_WAIT: The remote host has shutdown and we're waiting for the socket to close
5- TIME_WAIT: The socket is waiting after close to handle packets still in the network
        ";
 
    }

    public void lessonOneHundredSeventyNineButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=false;
        lessonOneHundredSeventySixButton.IsVisible=false;
        lessonOneHundredSeventySevenButton.IsVisible=false;
        lessonOneHundredSeventyEightButton.IsVisible=false;
        lessonOneHundredSeventyNineButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The subject of packet analysis could fill an entire course of its own and there are many books written just on packet analysis. 
However, today we will just learn the basics. 

There are two extremely popular packet analyzers, Wireshark and tcpdump. 
These tools scan your network interfaces, capture the packet activity, parse the packages and output the information for us to see. 
They allows us to get into the nitty gritty of network analysis and get into the low level stuff. 
We'll be using tcpdump since it has a simpler interface, however if you were to pick up packet analysis for your toolbelt, 
I would recommend looking into Wireshark.


Install tcpdump:
""sudo apt install tcpdump""


Capture packet data on an interface:

""sudo tcpdump -i wlan0""
tcpdump: verbose output suppressed, use -v or -vv for full protocol decode
listening on wlan0, link-type EN10MB (Ethernet), capture size 65535 bytes
11:28:23.958840 IP icebox.lan > nuq04s29-in-f4.1e100.net: ICMP echo request, id 1901, seq 2, length 64
11:28:23.970928 IP nuq04s29-in-f4.1e100.net > icebox.lan: ICMP echo reply, id 1901, seq 2, length 64
11:28:24.960464 IP icebox.lan > nuq04s29-in-f4.1e100.net: ICMP echo request, id 1901, seq 3, length 64
11:28:24.979299 IP nuq04s29-in-f4.1e100.net > icebox.lan: ICMP echo reply, id 1901, seq 3, length 64
11:28:25.961869 IP icebox.lan > nuq04s29-in-f4.1e100.net: ICMP echo request, id 1901, seq 4, length 64
11:28:25.976176 IP nuq04s29-in-f4.1e100.net > icebox.lan: ICMP echo reply, id 1901, seq 4, length 64
11:28:26.963667 IP icebox.lan > nuq04s29-in-f4.1e100.net: ICMP echo request, id 1901, seq 5, length 64
11:28:26.976137 IP nuq04s29-in-f4.1e100.net > icebox.lan: ICMP echo reply, id 1901, seq 5, length 64
11:28:30.674953 ARP, Request who-has 172.254.1.0 tell ThePickleParty.lan, length 28
11:28:31.190665 IP ThePickleParty.lan.51056 > 192.168.86.255.rfe: UDP, length 306

You'll notice a lot of stuff happening when you run a packet capture, well that's to be expected there's a lot of network activity happening in the background. 
In my above example, I've taken only a snippet of my capture specifically the time when I decided to ping www.google.com. 


Understanding the output:

11:28:23.958840 IP icebox.lan > nuq04s29-in-f4.1e100.net: ICMP echo request, id 1901, seq 2, length 64
11:28:23.970928 IP nuq04s29-in-f4.1e100.net > icebox.lan: ICMP echo reply, id 1901, seq 2, length 64

1- The first field is a timestamp of the network activity
2- IP, this contains the protocol information
3- Next, you'll see the source and destination address: icebox.lan > nuq04s29-in-f4.1e100.net
4- seq, this is the TCP packets's starting and ending sequence number
5- length, length in bytes

As you can see from our tcpdump output, we are sending an ICMP echo request packet to www.google.com and getting an ICMP echo reply packet in return! 
Also note that different packets will output different information, refer to the manpage to see what those are.


Writing tcpdump output to a file:
""sudo tcpdump -w /some/file""


Some final thoughts: we only scraped the surface of the subject of packet analysis. 
There is so much you can look at and we haven't even touched upon going even deeper with Hex and ASCII output. 
There are plenty of resources online to help you learn more about packet analyzers and I urge you to find them!       
        ";
     
    }

    //DNS Lessons

    public void lessonOneHundredEightyButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=false;
        lessonOneHundredEightyOneButton.IsVisible=false;
        lessonOneHundredEightyTwoButton.IsVisible=false;
        lessonOneHundredEightyThreeButton.IsVisible=false;
        lessonOneHundredEightyFourButton.IsVisible=false;
        lessonOneHundredEightyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Imagine if every time you wanted to do a search on Google you had to type in http://192.78.12.4 instead of www.google.com. 
Well without DNS (""Domain Name System"") that's exactly what would happen. 

Low level networking only understands the raw IP address to identify a host. 
DNS allows us humans to keep track of websites and hosts by name instead of an IP address.  
It's like a contact list for the Internet. If you know someone's name but don’t know their phone number, you can simply look it up in your contacts list.



DNS is fundamentally a distributed database of hostnames to IP addresses, we manage our database so people know how to get to our site/domain, 
and somewhere else another person is managing their database so others can get to their domain. 
These domains are then able to talk to each other and build a massive contact list of the Internet.


In this course, we will go over some basics of DNS, but be wary that DNS is an exhaustive topic and if you really want to get down and dirty with it, you'll need to do some additional research.
        ";
 
    }

    public void lessonOneHundredEightyOneButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=false;
        lessonOneHundredEightyOneButton.IsVisible=false;
        lessonOneHundredEightyTwoButton.IsVisible=false;
        lessonOneHundredEightyThreeButton.IsVisible=false;
        lessonOneHundredEightyFourButton.IsVisible=false;
        lessonOneHundredEightyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
The DNS database of the Internet relies on sites and organizations providing part of that database. To do that, they need:


Name Server:
We setup DNS via ""name servers"", the name servers load up our DNS settings and configs and answers any questions from clients or other servers that want to know things like ""Who is google.com?"". 
If the name server doesn't know the answer to that query, it will redirect the request to other name servers. 

Name servers can be ""authoritative"", meaning they hold the actual DNS records that you're looking for, 
or ""recursive"" meaning they would ask other servers and those servers would ask other servers until they found an authoritative server that contained the DNS records. 
Recursive servers can also have the information we want cached instead of reaching an authoritative server.


Zone File:
Inside a name server lives something called zone files. 
Zone files are how the name server stores information about the domain or how to get to the domain if it doesn't know. 


Resource Records:
A zone file is comprised of entries of resource records. 
Each line is a record and contains information about hosts, nameservers, other resources, etc. 

The fields consist of the following: 
1- Record name

2- TTL - The time after which we discard the record and obtain a new one, in DNS TTL is denoted by time, 
so records could have a TTL of one hour. The reason we do this is because the Internet is constantly changing, one minute a host can be mapped to X IP address then next it can be at Y IP address

3- Class - Namespace of the record information, most commonly IN is used for Internet

4- Type - Type of information stored in the record data. We won't get into record types, but you've probably seen common ones like A for address, MX or mail exchanger, etc.

5- Data - This field can contain an IP address if it's an A record or something else depending on the record type.


""patty    IN  A      192.168.0.4""
        ";
 
    }

    public void lessonOneHundredEightyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=false;
        lessonOneHundredEightyOneButton.IsVisible=false;
        lessonOneHundredEightyTwoButton.IsVisible=false;
        lessonOneHundredEightyThreeButton.IsVisible=false;
        lessonOneHundredEightyFourButton.IsVisible=false;
        lessonOneHundredEightyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Let's look at an example of how your host finds a domain (catzontheinterwebz.com) with DNS. 
Essentially, we funnel our way down until we reach the DNS server that knows of that domain.


Local DNS Server:
First our host asks, ""Where is catzontheinterwebz.com?"", our local DNS server doesn't know so it goes and starts from the top of the funnel to ask the Root Servers. 
Keep in mind that our host is not making these requests to find catzontheinterwebz.com directly, 
most users talk to a recursive DNS server provided by their ISPs and that server is then tasked to find the location of catzontheinterwebz.com.


Root Servers:
There are 13 Root Servers for the Internet, they are mirrored and distributed around the world to handle DNS requests for the Internet, 
so there are really hundreds of servers that are working, they are controlled by different organizations and they contain information about Top-Level Domains. 

Top-level domains are what you know as .org, .com, .net, etc addresses. 
So the Root Server doesn't know where catzontheinterwebz.com is, so it tells us ask the .com Top-Level Domain DNS Server at an IP address it gives us. 


Top-Level Domain:
So now we send another request to the name server that knows about "".com"" addresses and asks if it knows where catzontheinterwebz.com is? 
The TLD doesn't have the catzontheinterwebz.com in their zone files, but it does see a record for the name server for catzontheinterwebz.com. 
So it gives us the IP address of that name server and tells us to look there.


Authoritative DNS Server:
Now we send a final request to the DNS server that actually has the record we want. 
The name server sees that it has a zone file for catzontheinterwebz.com and there is a resource record for 'www' for this host. 
It then gives us the IP address of this host and we can finally see some cats on the Internet.       
        ";
 
    }

    public void lessonOneHundredEightyThreeButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=false;
        lessonOneHundredEightyOneButton.IsVisible=false;
        lessonOneHundredEightyTwoButton.IsVisible=false;
        lessonOneHundredEightyThreeButton.IsVisible=false;
        lessonOneHundredEightyFourButton.IsVisible=false;
        lessonOneHundredEightyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
Before our machine actually hits DNS to do a query, it first looks locally on our machines. 


/etc/hosts:
The /etc/hosts file contains mappings of some hostnames to IP addresses. 
The fields are pretty self explanatory, there is one for the IP address, the hostname and then any alias's for the host. 

""cat /etc/hosts""
127.0.0.1       localhost
127.0.1.1       icebox

You'll typically see your localhost address listed as a default in this file. 
You can also manage access to hosts by modifying the /etc/hosts.deny or /etc/hosts.allow files. 
However, if you were security conscientious, this isn't really the way to go and you should be modifying your firewall rules instead. 


Let's see a fun example of /etc/hosts. Modify the file and add a line for:
""123.45.6.7  www.google.com""

Save the file and now go to www.google.com. 
Having issues aren't you? Well that's because we just mapped www.google.com to a completely wrong IP address. 
Since our hosts first look locally for IP address mappings, it never reaches DNS to find google.com. 


/etc/resolv.conf:
Traditionally, we've used a file called /etc/resolv.conf to map DNS name servers for more efficient lookups, 
however with the improvements made to DNS this file is quite often irrelevant, in fact, you can see in my example below that /etc/resolv.conf isn't managed manually. 
Refer to your distribution specific settings to manage DNS name server mappings.

conf(5) file for glibc resolver(3) generated by resolvconf(8)
#     DO NOT EDIT THIS FILE BY HAND -- YOUR CHANGES WILL BE OVERWRITTEN
nameserver 127.0.1.1
search localdomain
        ";
 
    }

    public void lessonOneHundredEightyFourButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=false;
        lessonOneHundredEightyOneButton.IsVisible=false;
        lessonOneHundredEightyTwoButton.IsVisible=false;
        lessonOneHundredEightyThreeButton.IsVisible=false;
        lessonOneHundredEightyFourButton.IsVisible=false;
        lessonOneHundredEightyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
We won't got through setting up a DNS server, as that would be quite a lengthy tutorial. 
Instead here is a quick comparison list of the popular DNS servers to use with Linux.


BIND:
The most popular DNS server on the Internet, it's the standard that is used with Linux distributions. 
It was originally developed at the University of California at Berkeley hence the name BIND (Berkeley Internet Name Domain). 
If you need full-featured power and flexibility, you can't go wrong with BIND.


DNSmasq:
Lightweight and much easier to configure than BIND. 
If you want simplicity and don't need all the bells and whistles of BIND, use DNSmasq. 
It comes with all the tools you need to setup DHCP and DNS, recommended for a smaller network.


PowerDNS:
Full-featured and similar to BIND, it offers you a little bit more flexibility with options. 
It reads information from multiple databases such as MySQL, PostgreSQL, etc. for easier administration. 
Just because BIND has been the way we do things, it doesn't mean it has to stay that way.


This isn't a complete list, but it should give you an idea of where to look if you are setting up your own DNS server.         
        ";
 
    }

    public void lessonOneHundredEightyFiveButton_Click(object sender, RoutedEventArgs e)
    {
        lessonsLabel.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=false;
        lessonOneHundredEightyOneButton.IsVisible=false;
        lessonOneHundredEightyTwoButton.IsVisible=false;
        lessonOneHundredEightyThreeButton.IsVisible=false;
        lessonOneHundredEightyFourButton.IsVisible=false;
        lessonOneHundredEightyFiveButton.IsVisible=false;

        lessonContent.IsVisible=true;
        lessonContent.Content=
        @"
nslookup:

The ""name server lookup"" tool is used to query name servers to find information about resource records. 
Let's find where the name server for google.com is:

""nslookup www.google.com""
Server:         127.0.1.1
Address:        127.0.1.1#53

Non-authoritative answer:
Name:   www.google.com
Address: 216.58.192.4



dig:
Dig (domain information groper) is a powerful tool for getting information about DNS name servers, 
it is more flexible than nslookup and great for troubleshooting DNS issues.

""dig www.google.com""

; <<>> DiG 9.9.5-3-Ubuntu <<>> www.google.com
;; global options: +cmd
;; Got answer:
;; ->>HEADER<<- opcode: QUERY, status: NOERROR, id: 42376
;; flags: qr rd ra; QUERY: 1, ANSWER: 5, AUTHORITY: 0, ADDITIONAL: 1

;; OPT PSEUDOSECTION:
; EDNS: version: 0, flags:; MBZ: 0005 , udp: 512
;; QUESTION SECTION:
;www.google.com.                        IN      A

;; ANSWER SECTION:
www.google.com.         5       IN      A       74.125.239.147
www.google.com.         5       IN      A       74.125.239.144
www.google.com.         5       IN      A       74.125.239.146
www.google.com.         5       IN      A       74.125.239.145
www.google.com.         5       IN      A       74.125.239.148

;; Query time: 27 msec
;; SERVER: 127.0.1.1#53(127.0.1.1)
;; WHEN: Sun Feb 07 10:14:00 PST 2016
;; MSG SIZE  rcvd: 123
        ";
 
    }

}