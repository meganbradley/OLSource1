---
title: "Walkthrough: Multithreading with the BackgroundWorker Component (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: ff670fbf-a0ac-40c1-ab08-9ed53768f880
caps.latest.revision: 7
---
# Walkthrough: Multithreading with the BackgroundWorker Component (C#)
This walkthrough demonstrates how to create a multithreaded Windows Forms application that searches a text file for occurrences of a word. It demonstrates:  
  
-   Defining a class with a method that can be called by the \<xref:System.ComponentModel.BackgroundWorker*> component.  
  
-   Handling events raised by the \<xref:System.ComponentModel.BackgroundWorker*> component.  
  
-   Starting a \<xref:System.ComponentModel.BackgroundWorker*> component to run a method.  
  
-   Implementing a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> button that stops the \<xref:System.ComponentModel.BackgroundWorker*> component.  
  
### To create the user interface  
  
1.  Open a new C# Windows Forms Application project, and create a form named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
2.  Add two buttons and four text boxes to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
3.  Name the objects as shown in the following table.  
  
    |Object|Property|Setting|  
    |------------|--------------|-------------|  
    |First button|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Start, Start|  
    |Second button|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Cancel, Cancel|  
    |First text box|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|SourceFile, ""|  
    |Second text box|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|CompareString, ""|  
    |Third text box|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|WordsCounted, "0"|  
    |Fourth text box|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|LinesCounted, "0"|  
  
4.  Add a label next to each text box. Set the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> property for each label as shown in the following table.  
  
    |Object|Property|Setting|  
    |------------|--------------|-------------|  
    |First label|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Source File|  
    |Second label|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Compare String|  
    |Third label|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Matching Words|  
    |Fourth label|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Lines Counted|  
  
### To create a BackgroundWorker component and subscribe to its events  
  
1.  Add a \<xref:System.ComponentModel.BackgroundWorker*> component from the **Components** section of the **ToolBox** to the form. It will appear in the form's component tray.  
  
2.  Set the following properties for the backgroundWorker1 object.  
  
    |Property|Setting|  
    |--------------|-------------|  
    |<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|True|  
    |<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|True|  
  
3.  Subscribe to the events of the backgroundWorker1 object. At the top of the **Properties** window, click the **Events** icon. Double-click the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> event to create an event handler method. Do the same for the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> events.  
  
### To define the method that will run on a separate thread  
  
1.  From the **Project** menu, choose **Add Class** to add a class to the project. The **Add New Item** dialog box is displayed.  
  
2.  Select **Class** from the templates window and enter <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in the name field.  
  
3.  Click **Add**. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class is displayed.  
  
4.  Add the following code to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To handle events from the thread  
  
-   Add the following event handlers to your main form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### To start and call a new thread that runs the WordCount method  
  
1.  Add the following procedures to your program:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Call the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method from the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> button on your form:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    ##### To implement a Cancel button that stops the thread  
  
    -   Call the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> procedure from the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> event handler for the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> button.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Testing  
 You can now test the application to make sure it works correctly.  
  
#### To test the application  
  
1.  Press F5 to run the application.  
  
2.  When the form is displayed, enter the file path for the file you want to test in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> box. For example, assuming your test file is named Test.txt, enter C:\Test.txt.  
  
3.  In the second text box, enter a word or phrase for the application to search for in the text file.  
  
4.  Click the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> button. The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> button should begin incrementing immediately. The application displays the message "Finished Counting" when it is done.  
  
#### To test the Cancel button  
  
1.  Press F5 to start the application, and enter the file name and search word as described in the previous procedure. Make sure that the file you choose is large enough to ensure you will have time to cancel the procedure before it is finished.  
  
2.  Click the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> button to start the application.  
  
3.  Click the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> button. The application should stop counting immediately.  
  
## Next Steps  
 This application contains some basic error handling. It detects blank search strings. You can make this program more robust by handling other errors, such as exceeding the maximum number of words or lines that can be counted.  
  
## See Also  
 [Threading (C#)](../vs140/threading--csharp-.md)   
 [How To: Subscribe To and Unsubscribe from Events (C# Programming Guide)](../vs140/how-to--subscribe-to-and-unsubscribe-from-events--csharp-programming-guide-.md)