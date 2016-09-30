---
title: "How to: Access and Constrain the Current Selection"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, accessing the current selection"
ms.assetid: 2990981e-dfae-416f-b0d0-7197f1242dfa
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Access and Constrain the Current Selection
When you write a command or gesture handler for your domain-specific language, you can determine what element the user right-clicked. You can also prevent some shapes or fields from being selected. For example, you can arrange that when the user clicks an icon decorator, the shape that contains it is selected instead. Constraining the selection in this manner reduces the number of handlers that you have to write. It also makes it easier for the user, who can click anywhere in the shape without having to avoid the decorator.  
  
## Accessing the Current Selection from a Command Handler  
 The command set class for a domain-specific language contains the command handlers for your custom commands. The \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*> class, from which the command set class for a domain-specific language derives, provides a few members for accessing the current selection.  
  
 Depending on the command, the command handler might need the selection in the model designer, the model explorer, or the active window.  
  
#### To access selection information  
  
1.  The \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*> class defines the following members that can be used to access the current selection.  
  
    |Member|Description|  
    |------------|-----------------|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsAnyDocumentSelectionCompartment*> method|Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if any of the elements selected in the model designer is a compartment shape; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsDiagramSelected*> method|Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the diagram is selected in the model designer; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsSingleDocumentSelection*> method|Returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if exactly one element is selected in the model designer; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsSingleSelection*> method|Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if exactly one element is selected in the active window; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.CurrentDocumentSelection*> property|Gets a read-only collection of the elements selected in the model designer.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.CurrentSelection*> property|Gets a read-only collection of the elements selected in the active window.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.SingleDocumentSelection*> property|Gets the primary element of the selection in the model designer.|  
    |\<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.SingleSelection*> property|Gets the primary element of the selection in the active window.|  
  
2.  The \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet.CurrentDocView*> property of the \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*> class provides access to the \<xref:Microsoft.VisualStudio.Modeling.Shell.DiagramDocView*> object that represents the model designer window and provides additional access the selected elements in the model designer.  
  
3.  In addition, the generated code defines an explorer tool window property and an explorer selection property in the command set class for the domain-specific language.  
  
    -   The explorer tool window property returns an instance of the explorer tool window class for the domain-specific language. The explorer tool window class derives from the \<xref:Microsoft.VisualStudio.Modeling.Shell.ModelExplorerToolWindow*> class and represents the model explorer for the domain-specific language.  
  
    -   The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> property returns the selected element in the model explorer window for the domain-specific language.  
  
## Determining which window is active  
 The \<xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService*> interface contains defines members that provide access to the current selection state in the shell. You can get an \<xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService*> object from either the package class or the command set class for the domain-specific language through the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property defined in the base class of each. The package class derives from the \<xref:Microsoft.VisualStudio.Modeling.Shell.ModelingPackage*> class, and the command set class derives from the \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*> class.  
  
#### To determine from a command handler what type of window is active  
  
1.  The \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.MonitorSelection*> property of the \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*> class returns an \<xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService*> object that provides access to the current selection state in the shell.  
  
2.  The \<xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService.CurrentSelectionContainer*> property of the \<xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService*> interface gets the active selection container, which can be different from the active window.  
  
3.  Add the following properties to the command set class for you domain-specific language to determine what type of window is active.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Constraining the Selection  
 By adding selection rules, you can control which elements are selected when the user selects an element in the model. For example, to allow the user to treat a number of elements as a single unit, you can use a selection rule.  
  
#### To create a selection rule  
  
1.  Create a custom code file in the DSL project  
  
2.  Define a selection rule class that is derived from the \<xref:Microsoft.VisualStudio.Modeling.Diagrams.DiagramSelectionRules*> class.  
  
3.  Override the \<xref:Microsoft.VisualStudio.Modeling.Diagrams.DiagramSelectionRules.GetCompliantSelection*> method of the selection rule class to apply the selection criteria.  
  
4.  Add a partial class definition for the ClassDiagram class to your custom code file.  
  
     The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class derives from the \<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram*> class and is defined in the generated code file, Diagram.cs, in the DSL project.  
  
5.  Override the \<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.SelectionRules*> property of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class to return the custom selection rule.  
  
     The default implementation of the \<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.SelectionRules*> property gets a selection rule object that does not modify the selection.  
  
### Example  
 The following code file creates a selection rule that expands the selection to include all instances of each of the domain shapes that was initially selected.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*>   
 \<xref:Microsoft.VisualStudio.Modeling.Shell.ModelingPackage*>   
 \<xref:Microsoft.VisualStudio.Modeling.Shell.DiagramDocView*>   
 \<xref:Microsoft.VisualStudio.Modeling.Shell.ModelExplorerToolWindow*>   
 \<xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService*>   
 \<xref:Microsoft.VisualStudio.Modeling.Diagrams.DiagramSelectionRules*>   
 \<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram*>