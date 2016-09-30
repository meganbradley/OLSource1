---
title: "Exposing Properties to the Properties Window"
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
  - "properties [Visual Studio SDK], exposing in Property Browser"
  - "properties [Visual Studio SDK]"
  - "Property Browser, exposing properties"
ms.assetid: 47f295b5-1ca5-4e7b-bb52-7b926b136622
caps.latest.revision: 40
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Exposing Properties to the Properties Window
This walkthrough exposes the public properties of an object to the **Properties** window. The changes you make to these properties are reflected in the **Properties** window.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Exposing Properties to the Properties Window  
 In this section, you create a custom tool window and display the public properties of the associated window pane object in the **Properties** window.  
  
#### To expose properties to the Properties window  
  
1.  Every Visual Studio extension starts with a VSIX deployment project which will contain the extension assets. Create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] VSIX project named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  Add a tool window by adding a Custom Tool Window item template named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item dialog**, go to **Visual C# Items / Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the dialog, change the file name to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For more information about how to create a custom tool window, see [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md).  
  
3.  Open MyToolWindow.cs and add the following using statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Now add the following fields to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Add the following code to the MyToolWindow class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property uses <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to obtain an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> service, which provides an \<xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection*> interface. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> event handler and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method together create a list of selected objects that contains only the tool window pane object itself. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method tells the **Properties** window to display the public properties of the tool window pane.  
  
6.  Build the project and start debugging. The experimental instance of Visual Studio should appear.  
  
7.  If the **Properties** window is not visible, open it by pressing F4.  
  
8.  Open the **MyToolWindow** window. You can find it in **View / Other Windows**.  
  
     The window opens and the public properties of the window pane appear in the **Properties** window.  
  
9. Change the **Caption** property in the **Properties** window to **My Object Properties**.  
  
     The MyToolWindow window caption changes accordingly.  
  
## Exposing Tool Window Properties  
 In this section, you add a tool window and expose its properties. The changes you make to properties are reflected in the **Properties** window.  
  
#### To expose tool window properties  
  
1.  Open MyToolWindow.cs, and add the public boolean property IsChecked to the MyToolWindow class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     This property gets its state from the WPF checkbox you will create later.  
  
2.  Open MyToolWindowControl.xaml.cs and replace the MyToolWindowControl constructor with the following code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     This gives <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> access to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> pane.  
  
3.  In MyToolWindow.cs, change the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> constructor as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  Change to the design view of MyToolWindowControl.  
  
5.  Delete the button and add a check box from the **Toolbox** to the upper left corner.  
  
6.  Add the Checked and Unchecked events. Select the checkbox in the design view. In the **Properties** window, click the event handlers button (at the top right of the **Properties** window). Find **Checked** and type **checkbox_Checked** in the text box, then find **Unchecked** and type **checkbox_Unchecked** in the text box.  
  
7.  Add the check box event handlers:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
8.  Build the project and start debugging.  
  
9. In the experimental instance, open the **MyToolWindow** window.  
  
     Look for the window’s properties in the **Properties** window. The **IsChecked** property appears at the bottom of the window, under the **My Properties** category.  
  
10. Check the check box in the **MyToolWindow** window. **IsChecked** in the **Properties** window changes to **True**. Clear the check box in the **MyToolWindow** window. **IsChecked** in the **Properties** window changes to **False**. Change the value of **IsChecked** in the **Properties** window. The check box in the **MyToolWindow** window changes to match the new value.  
  
    > [!NOTE]
    >  If you must dispose of an object that is displayed in the **Properties** window, call <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> with a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> selection container first. After disposing the property or object, you can change to a selection container that has updated \<xref:Microsoft.VisualStudio.Shell.SelectionContainer.SelectableObjects*> and \<xref:Microsoft.VisualStudio.Shell.SelectionContainer.SelectedObjects*> lists.  
  
## Changing Selection Lists  
 In this section, you add a selection list for a basic property class and use the tool window interface to choose which selection list to display.  
  
#### To change selection lists  
  
1.  Open MyToolWindow.cs and add a public class named <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  Add a SimpleObject property to the MyToolWindow class, plus two methods to switch the **Properties** window selection between the window pane and the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
3.  In MyToolWindowControl.cs, replace the check box handlers with these lines of code:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
4.  Build the project and start debugging.  
  
5.  In the experimental instance, open the **MyToolWindow** window.  
  
6.  Select the check box in the **MyToolWindow** window. The **Properties** window displays the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object properties, **SomeText** and **ReadOnly**. Clear the check box. The public properties of the window appear in the **Properties** window.  
  
    > [!NOTE]
    >  The display name of **SomeText** is **My Text**.  
  
## Best Practice  
 In this walkthrough, \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*> is implemented so that the selectable object collection and the selected object collection are the same collection. Only the selected object appears in the Property Browser list. For a more complete ISelectionContainer implementation, see the Reference.ToolWindow samples.  
  
 Visual Studio tool windows persist between Visual Studio sessions. For more information on persisting the tool window state, see \<xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute*>.  
  
## See Also  
 [Support for the Properties Window](../vs140/extending-properties-and-the-property-window.md)