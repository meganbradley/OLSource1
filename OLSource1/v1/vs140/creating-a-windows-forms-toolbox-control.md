---
title: "Creating a Windows Forms Toolbox Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "winforms"
  - "toolbox"
  - "windows forms"
ms.assetid: 0be6ffc1-8afd-4d02-9a5d-e27dde05fde6
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating a Windows Forms Toolbox Control
The Windows Forms Toolbox Control item template that is included in the Visual Studio Extensibility Tools (VS SDK) lets you create a control that is automatically added to the **Toolbox** when the extension is installed. This topic shows how to use the template to create a simple counter control that you can distribute to other users.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Windows Forms Toolbox Control  
 The Windows Forms Toolbox Control template creates an undefined user control and provides all of the functionality that is required to add the control to the **Toolbox**.  
  
#### Create an extension with a Windows Forms Toolbox Control  
  
1.  Create a VSIX project named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  When the project opens, add a **Windows Forms Toolbox Control** item template named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Windows Forms Toolbox Control**  
  
3.  This adds a user control, a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>\<xref:Microsoft.VisualStudio.Shell.RegistrationAttribute*> to place the control in the **Toolbox**, and a **Microsoft.VisualStudio.ToolboxControl** Asset entry in the VSIX manifest for deployment.  
  
### Building a User Interface for the Control  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> control requires two child controls: a \<xref:System.Windows.Forms.Label*> to display the current count, and a \<xref:System.Windows.Forms.Button*> to reset the count to 0. No other child controls are required because callers will increment the counter programmatically.  
  
##### To build the user interface  
  
1.  In **Solution Explorer**, double-click Counter.cs to open it in the designer.  
  
2.  Remove the “Click Here !” **Button** that is included by default when you add the Windows Forms Toolbox Control item template.  
  
3.  From the **Toolbox**, drag a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> control and then a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> control below it to the design surface.  
  
4.  Resize the overall user control to 150, 50 pixels, and resize the button control to 50, 20 pixels.  
  
5.  In the **Properties** window, set the following values for the controls on the design surface.  
  
    |Control|Property|Value|  
    |-------------|--------------|-----------|  
    |<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|**Text**|""|  
    |<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|**Name**|btnReset|  
    |<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|**Text**|Reset|  
  
### Coding the User Control  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> control will expose a method to increment the counter, an event to be raised whenever the counter is incremented, a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> button, and three properties to store the current count, the display text, and whether to show or hide the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> button. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute determines where in the **Toolbox** the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> control will appear.  
  
##### To code the user control  
  
1.  Double-click the form to open its load event handler in the code window.  
  
2.  Above the event handler method, in the control class create an integer to store the counter value and a string to store the display text as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Create the following public property declarations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Callers can access these properties to get and set the display text of the counter and to show or hide the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> button. Callers can obtain the current value of the read-only <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> property, but they cannot set the value directly.  
  
4.  Put the following code in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> event for the control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Setting the **Label** text in the \<xref:System.Windows.Forms.UserControl.Load*> event enables the target properties to load before their values are applied. Setting the **Label** text in the constructor would result in an empty **Label**.  
  
5.  Create the following public method to increment the counter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  Add a declaration for the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> event to the control class.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     Callers can add handlers to this event to respond to changes in the value of the counter.  
  
7.  Return to design view and double-click the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> button to generate the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> event handler, and then fill it in as shown in the following example.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
8.  Immediately above the class definition, in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attribute declaration, change the value of the first parameter from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. This sets the name of the item group that will host the control in the **Toolbox**.  
  
     The following example shows the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> attribute and the adjusted class definition.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Testing the Control  
 To test a **Toolbox** control, first test it in the development environment and then test it in a compiled application.  
  
##### To test the control  
  
1.  Press F5.  
  
     This builds the project and opens a second Experimental instance of Visual Studio that has the control installed.  
  
2.  In the Experimental instance of Visual Studio, create a **Windows Forms Application** project.  
  
3.  In **Solution Explorer**, double-click Form1.cs to open it in the designer if it is not already open.  
  
4.  In the **Toolbox**, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> control should be displayed in the **General** section.  
  
5.  Drag a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> control to your form, and then select it. The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> properties will be displayed in the **Properties** window, together with the properties that are inherited from \<xref:System.Windows.Forms.UserControl*>.  
  
6.  Set the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
7.  Drag a \<xref:System.Windows.Forms.Button*> control to the form, and then set the name and text properties of the button to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
8.  Double-click the button to open Form1.cs in code view and create a click handler.  
  
9. In the click handler, call <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
10. In the constructor function, after the call to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and then press TAB twice.  
  
     Visual Studio generates a form-level handler for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> event.  
  
11. Highlight the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement in the event handler, type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and then press TAB twice to generate a message box from the mbox code snippet.  
  
12. On the next line, add the following <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> block to set the visibility of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
13. Press F5.  
  
     The form opens. The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> control displays the following text.  
  
     **Count: 0**  
  
14. Click **Test**.  
  
     The counter increments and Visual Studio displays a message box.  
  
15. Close the message box.  
  
     The **Reset** button disappears.  
  
16. Click **Test** until the counter reaches **5** closing the message boxes each time.  
  
     The **Reset** button re-appears.  
  
17. Click **Reset**.  
  
     The counter resets to **0**.  
  
## Next Steps  
 When you build a **Toolbox** control, Visual Studio creates a file named *ProjectName*.vsix in the \bin\debug\ folder of your project. You can deploy the control by uploading the .vsix file to a network or to a Web site. When a user opens the .vsix file, the control is installed and added to the Visual Studio **Toolbox** on the user's computer. Alternatively, you can upload the .vsix file to the [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkID=123847) Web site so that users can find it by browsing in the **Tools / Extension and Updates** dialog.  
  
## See Also  
 [Toolbox (Visual Studio SDK)](../vs140/extending-the-toolbox.md)   
 [Creating a WPF Toolbox Control](../vs140/creating-a-wpf-toolbox-control.md)   
 [Extending Other Parts of Visual Studio](../vs140/extending-other-parts-of-visual-studio.md)   
 [Windows Forms Control Development Basics](assetId:///6277bb81-90f7-4c5b-9f4b-b02bb42dd316)