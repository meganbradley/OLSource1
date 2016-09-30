---
title: "Embedding a Diagram in a Windows Form"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: fa6cd040-7c88-4329-b9c3-2a80b312610f
caps.latest.revision: 6
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Embedding a Diagram in a Windows Form
You can embed a DSL diagram in a Windows Control, which appears in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] window.  
  
## Embedding a Diagram  
  
#### To embed a DSL diagram in a Windows Control  
  
1.  Add a new **User Control** file to the DslPackage project.  
  
2.  Add a Panel control to the User Control. This panel will contain the DSL Diagram.  
  
     Add other controls that you require.  
  
     Set the Anchor properties of the controls.  
  
3.  In Solution Explorer, right-click the user control file and click **View Code**. Add this constructor and variable to the code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Add a new file to the DslPackage project, with the following content:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  To test the DSL, press F5 and open a sample model file. The diagram appears inside the control. The toolbox and other features work normally.  
  
#### Updating the Form using Store Events  
  
1.  In the form designer, add a **ListBox** named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This will display a list of the elements in the model. It will be kept in synchronism with the model using *store events*. For more information, see [Event Handlers Propagate Changes Outside the Model](../vs140/event-handlers-propagate-changes-outside-the-model.md).  
  
2.  In the custom code file, override further methods to the DocView class:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  In the code behind the user control, insert methods to listen for elements added and removed:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  To test the DSL, press F5 and in the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], open a sample model file.  
  
     Notice that the list box shows a list of the elements in the model, and that it is correct after any addition or deletion, and after Undo and Redo.  
  
## See Also  
 [Navigating and Updating a Model](../vs140/navigating-and-updating-a-model-in-program-code.md)   
 [Writing Code to Customize a Domain-Specific Language](../vs140/writing-code-to-customise-a-domain-specific-language.md)