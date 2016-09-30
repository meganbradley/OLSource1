---
title: "Walkthrough: Declaring and Raising Events (Visual Basic)"
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
  - "declarations, events"
  - "events [Visual Basic], walkthroughs"
  - "declaring events, walkthroughs"
  - "events [Visual Basic], declaring"
  - "events [Visual Basic], raising"
  - "raising events, walkthroughs"
ms.assetid: 8ffb3be8-097d-4d3c-b71e-04555ebda2a2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Declaring and Raising Events (Visual Basic)
This walkthrough demonstrates how to declare and raise events for a class named <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. After you complete the steps, you might want to read the companion topic, [Walkthrough: Handling Events](../vs140/walkthrough--handling-events--visual-basic-.md), which shows how to use events from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects to provide status information in an application.  
  
## The Widget Class  
 Assume for the moment that you have a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class. Your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class has a method that can take a long time to execute, and you want your application to be able to put up some kind of completion indicator.  
  
 Of course, you could make the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object show a percent-complete dialog box, but then you would be stuck with that dialog box in every project in which you used the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class. A good principle of object design is to let the application that uses an object handle the user interface—unless the whole purpose of the object is to manage a form or dialog box.  
  
 The purpose of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is to perform other tasks, so it is better to add a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> event and let the procedure that calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>'s methods handle that event and display status updates. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> event can also provide a mechanism for canceling the task.  
  
#### To build the code example for this topic  
  
1.  Open a new [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] Windows Application project and create a form named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
2.  Add two buttons and a label to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
3.  Name the objects as shown in the following table.  
  
    |Object|Property|Setting|  
    |------------|--------------|-------------|  
    |<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Start Task|  
    |<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Cancel|  
    |<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|lblPercentDone, 0|  
  
4.  On the **Project** menu, choose **Add Class** to add a class named <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to the project.  
  
#### To declare an event for the Widget class  
  
-   Use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword to declare an event in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class. Note that an event can have <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> arguments, as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> event demonstrates:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#1](../vs140/codesnippet/VisualBasic/walkthrough--declaring-and-raising-events--visual-basic-_1.vb)]  
  
 When the calling object receives a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> event, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> argument contains the percentage of the task that is complete. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> argument can be set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to cancel the method that raised the event.  
  
> [!NOTE]
>  You can declare event arguments just as you do arguments of procedures, with the following exceptions: Events cannot have <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> arguments, and events do not have return values.  
  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> event is raised by the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> takes two arguments: the length of time the method pretends to be doing work, and the minimum time interval before <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> pauses to raise the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> event.  
  
#### To raise the PercentDone event  
  
1.  To simplify access to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> property used by this class, add an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement to the top of the declarations section of your class module, above the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statement.  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#2](../vs140/codesnippet/VisualBasic/walkthrough--declaring-and-raising-events--visual-basic-_2.vb)]  
  
2.  Add the following code to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> class:  
  
     [!code[VbVbcnWalkthroughDeclaringAndRaisingEvents#3](../vs140/codesnippet/VisualBasic/walkthrough--declaring-and-raising-events--visual-basic-_3.vb)]  
  
 When your application calls the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> class raises the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> event every <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> seconds. When the event returns, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> checks to see if the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> argument was set to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 A few disclaimers are necessary here. For simplicity, the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> procedure assumes you know in advance how long the task will take. This is almost never the case. Dividing tasks into chunks of even size can be difficult, and often what matters most to users is simply the amount of time that passes before they get an indication that something is happening.  
  
 You may have spotted another flaw in this sample. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> property returns the number of seconds that have passed since midnight; therefore, the application gets stuck if it is started just before midnight. A more careful approach to measuring time would take boundary conditions such as this into consideration, or avoid them altogether, using properties such as <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 Now that the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> class can raise events, you can move to the next walkthrough. [Walkthrough: Handling Events](../vs140/walkthrough--handling-events--visual-basic-.md) demonstrates how to use <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to associate an event handler with the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> event.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.DateAndTime.Timer*>   
 \<xref:Microsoft.VisualBasic.DateAndTime.Now*>   
 [Walkthrough: Handling Events](../vs140/walkthrough--handling-events--visual-basic-.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)