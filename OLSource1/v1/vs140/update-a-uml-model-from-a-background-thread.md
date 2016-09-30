---
title: "Update a UML model from a background thread"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 42c06b0b-b681-4e19-b5f3-6116dd2a4072
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Update a UML model from a background thread
It can sometimes be useful to make changes to a model in a background thread. For example, if you are loading information from a slow external resource, you could use a background thread to supervise the updates. This allows the user to see each update as soon as it happens.  
  
 However, you must be aware that the UML store is not thread safe. The following precautions are important:  
  
-   Every update to a model or diagram must be made in the user interface (UI) thread. The background thread must use \<xref:System.Windows.Forms.Control.Invoke*> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<xref:System.Windows.Threading.Dispatcher.Invoke*> to have the UI thread perform the actual updates.  
  
-   If you group a series of changes into a single transaction, we recommend that you prevent the user from editing the model while the transaction is in progress. Otherwise, any edits made by the user will become part of the same transaction. You can prevent the user from making changes by showing a modal dialog box. If you want, you can provide a Cancel button in the dialog box. The user can see the changes as they happen.  
  
## Example  
 This example uses a background thread to make several changes to a model. A dialog box is used to exclude the user while the thread is running. In this simple example, no Cancel button is provided in the dialog box. However, it would be easy to add that feature.  
  
#### To run the example  
  
1.  Create a command handler in a C# project as described in [How to Define a Menu Command on a Modeling Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
2.  Make sure that the project includes references to these assemblies:  
  
    -   Microsoft.VisualStudio.ArchitectureTools.Extensibility  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.[version]  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]  
  
    -   Microsoft.VisualStudio.Uml.Interfaces  
  
    -   System.ComponentModel.Composition  
  
    -   System.Windows.Forms  
  
3.  Add to the project a Windows form named **ProgressForm**. It should display a message that states that the updates are in progress. It does not have to have any other controls.  
  
4.  Add a C# file that contains the code that is shown after step 7.  
  
5.  Build and run the project.  
  
     A new instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] will start in experimental mode.  
  
6.  Create or open a UML class diagram in the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
7.  Right-click anywhere in the UML class diagram and then click **Add Several UML Classes**.  
  
 Several new class boxes will appear in the diagram, one after another at intervals of a half second.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### To allow the user to cancel the thread in the example  
  
1.  Add a cancel button to the progress dialog.  
  
2.  Add the following code to the progress dialog box:  
  
     <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
3.  In the Execute() method, insert this line after the construction of the form:  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
### Other methods of accessing the UI thread  
 If you do not want to create a dialog box, you can access the control that displays the diagram:  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 You can use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to perform operations in the UI thread.  
  
## See Also  
 [How to Define a Menu Command on a Modeling Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md)   
 [How to Define a Gesture Handler on a Modeling Diagram](../vs140/define-a-gesture-handler-on-a-modeling-diagram.md)