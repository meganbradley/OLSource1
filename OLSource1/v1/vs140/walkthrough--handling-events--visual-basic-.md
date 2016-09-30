---
title: "Walkthrough: Handling Events (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "event handling [Visual Basic], walkthroughs"
  - "walkthroughs [Visual Basic], event handling"
  - "variables [Visual Basic], WithEvents"
  - "events [Visual Basic], walkthroughs"
  - "WithEvents keyword, walkthroughs"
  - "event handlers [Visual Basic], walkthroughs"
ms.assetid: f145b3fc-5ae0-4509-a2aa-1ff6934706bd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Handling Events (Visual Basic)
This is the second of two topics that demonstrate how to work with events. The first topic, [Walkthrough: Declaring and Raising Events](../vs140/walkthrough--declaring-and-raising-events--visual-basic-.md), shows how to declare and raise events. This section uses the form and class from that walkthrough to show how to handle events when they take place.  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class example uses traditional event-handling statements. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides other techniques for working with events. As an exercise, you can modify this example to use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements.  
  
### To handle the PercentDone event of the Widget class  
  
1.  Place the following code in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#4](../vs140/codesnippet/VisualBasic/walkthrough--handling-events--visual-basic-_1.vb)]  
  
     The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword specifies that the variable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is used to handle an object's events. You specify the kind of object by supplying the name of the class from which the object will be created.  
  
     The variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is declared in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variables must be class-level. This is true regardless of the type of class you place them in.  
  
     The variable <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used to cancel the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method.  
  
## Writing Code to Handle an Event  
 As soon as you declare a variable using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the variable name appears in the left drop-down list of the class's **Code Editor**. When you select <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class's events appear in the right drop-down list. Selecting an event displays the corresponding event procedure, with the prefix <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and an underscore. All the event procedures associated with a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable are given the variable name as a prefix.  
  
#### To handle an event  
  
1.  Select <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> from the left drop-down list in the **Code Editor**.  
  
2.  Select the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> event from the right drop-down list. The **Code Editor** opens the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> event procedure.  
  
    > [!NOTE]
    >  The **Code Editor** is useful, but not required, for inserting new event handlers. In this walkthrough, it is more direct to just copy the event handlers directly into your code.  
  
3.  Add the following code to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> event handler:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#5](../vs140/codesnippet/VisualBasic/walkthrough--handling-events--visual-basic-_2.vb)]  
  
     Whenever the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> event is raised, the event procedure displays the percent complete in a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> control. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method allows the label to repaint, and also gives the user the opportunity to click the **Cancel** button.  
  
4.  Add the following code for the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> event handler:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#6](../vs140/codesnippet/VisualBasic/walkthrough--handling-events--visual-basic-_3.vb)]  
  
 If the user clicks the **Cancel** button while <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is running, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> event is executed as soon as the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement allows event processing to occur. The class-level variable <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> event then tests it and sets the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
## Connecting a WithEvents Variable to an Object  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is now set up to handle a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object's events. All that remains is to find a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> somewhere.  
  
 When you declare a variable <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> at design time, no object is associated with it. A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> variable is just like any other object variable. You have to create an object and assign a reference to it with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> variable.  
  
#### To create an object and assign a reference to it  
  
1.  Select **(Form1 Events)** from the left drop-down list in the **Code Editor**.  
  
2.  Select the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> event from the right drop-down list. The **Code Editor** opens the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> event procedure.  
  
3.  Add the following code for the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> event procedure to create the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#7](../vs140/codesnippet/VisualBasic/walkthrough--handling-events--visual-basic-_4.vb)]  
  
 When this code executes, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] creates a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object and connects its events to the event procedures associated with <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. From that point on, whenever the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> raises its <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> event, the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> event procedure is executed.  
  
#### To call the LongTask method  
  
-   Add the following code to the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> event handler:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#8](../vs140/codesnippet/VisualBasic/walkthrough--handling-events--visual-basic-_5.vb)]  
  
 Before the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> method is called, the label that displays the percent complete must be initialized, and the class-level <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> flag for canceling the method must be set to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is called with a task duration of 12.2 seconds. The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> event is raised once every one-third of a second. Each time the event is raised, the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> event procedure is executed.  
  
 When <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is done, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is tested to see if <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> ended normally, or if it stopped because <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> was set to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. The percent complete is updated only in the former case.  
  
#### To run the program  
  
1.  Press F5 to put the project in run mode.  
  
2.  Click the **Start Task** button. Each time the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> event is raised, the label is updated with the percentage of the task that is complete.  
  
3.  Click the **Cancel** button to stop the task. Notice that the appearance of the **Cancel** button does not change immediately when you click it. The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> event cannot happen until the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement allows event processing.  
  
    > [!NOTE]
    >  The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> method does not process events in exactly the same way as the form does. For example, in this walkthrough, you must click the **Cancel** button twice. To allow the form to handle the events directly, you can use multithreading. For more information, see [Threading (C# and Visual Basic)](../vs140/threading--csharp-and-visual-basic-.md).  
  
 You may find it instructive to run the program with F11 and step through the code a line at a time. You can clearly see how execution enters <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and then briefly re-enters <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> each time the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> event is raised.  
  
 What would happen if, while execution was back in the code of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> method were called again? At worst, a stack overflow might occur if <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> were called every time the event was raised.  
  
 You can cause the variable <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to handle events for a different <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object by assigning a reference to the new <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. In fact, you can make the code in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> do this every time you click the button.  
  
#### To handle events for a different widget  
  
-   Add the following line of code to the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> procedure, immediately preceding the line that reads <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#9](../vs140/codesnippet/VisualBasic/walkthrough--handling-events--visual-basic-_6.vb)]  
  
 The code above creates a new <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> each time the button is clicked. As soon as the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> method completes, the reference to the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is released, and the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is destroyed.  
  
 A <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> variable can contain only one object reference at a time, so if you assign a different <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, the previous <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object's events will no longer be handled. If <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is the only object variable containing a reference to the old <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, the object is destroyed. If you want to handle events from several <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> objects, use the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> statement to process events from each object separately.  
  
> [!NOTE]
>  You can declare as many <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> variables as you need, but arrays of <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> variables are not supported.  
  
## See Also  
 [Walkthrough: Declaring and Raising Events](../vs140/walkthrough--declaring-and-raising-events--visual-basic-.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)