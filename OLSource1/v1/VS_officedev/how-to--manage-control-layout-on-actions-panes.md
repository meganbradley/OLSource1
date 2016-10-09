---
title: "How to: Manage Control Layout on Actions Panes"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "actions panes [Office development in Visual Studio], control layout"
  - "controls [Office development in Visual Studio], layout on actions panes"
  - "smart documents [Office development in Visual Studio], control layout"
ms.assetid: 857550d0-b9c0-4d2f-a947-dd955bcf2823
caps.latest.revision: 59
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Manage Control Layout on Actions Panes
  An actions pane is docked to the right of a document or worksheet by default; however, it can be docked to the left, top, or bottom. If you are using multiple user controls, you can write code to properly stack the user controls on the actions pane. For more information, see [Actions Pane Overview](../VS_officedev/actions-pane-overview.md).  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
 The stack order of the controls depends on whether the actions pane is docked vertically or horizontally.  
  
> [!NOTE]  
>  If the user resizes the actions pane at run time, you can set the controls to resize with the actions pane. You can use the \<xref:System.Windows.Forms.Control.Anchor*> property of a Windows Forms control to anchor controls to the actions pane. For more information, see [How to: Anchor Controls on Windows Forms](../Topic/How%20to:%20Anchor%20Controls%20on%20Windows%20Forms.md).  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To set the stack order of the actions pane controls  
  
1.  Open a document-level project for Microsoft Office Word that includes an actions pane with multiple user controls or nested actions pane controls. For more information, see [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../VS_officedev/how-to--add-an-actions-pane-to-word-documents-or-excel-workbooks.md).  
  
2.  Right-click **ThisDocument.cs** or **ThisDocument.vb** in **Solution Explorer** and then click **View Code**.  
  
3.  In the \<xref:Microsoft.Office.Tools.ActionsPane.OrientationChanged> event handler of the actions pane, check if the orientation of the actions pane is horizontal.  
  
     [!code[Trin_VstcoreActionsPaneWord#30](../VS_officedev/codesnippet/CSharp/how-to--manage-control-layout-on-actions-panes_1.cs)]
[!code[Trin_VstcoreActionsPaneWord#30](../VS_officedev/codesnippet/VisualBasic/how-to--manage-control-layout-on-actions-panes_1.vb)]  
  
4.  If the orientation is horizontal, stack the action pane controls from the left; otherwise, stack them from the top.  
  
     [!code[Trin_VstcoreActionsPaneWord#31](../VS_officedev/codesnippet/CSharp/how-to--manage-control-layout-on-actions-panes_2.cs)]
[!code[Trin_VstcoreActionsPaneWord#31](../VS_officedev/codesnippet/VisualBasic/how-to--manage-control-layout-on-actions-panes_2.vb)]  
  
5.  In C#, you must add an event handler for the `ActionsPane` to the \<xref:Microsoft.Office.Tools.Word.Document.Startup> event handler. For information about creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_VstcoreActionsPaneWord#32](../VS_officedev/codesnippet/CSharp/how-to--manage-control-layout-on-actions-panes_3.cs)]  
  
6.  Run the project and verify that the actions pane controls are stacked left to right when the actions pane is docked at the top of the document, and the controls are stacked from top to bottom when the actions pane is docked at the right side of the document.  
  
## Example  
 [!code[Trin_VstcoreActionsPaneWord#29](../VS_officedev/codesnippet/CSharp/how-to--manage-control-layout-on-actions-panes_4.cs)]
[!code[Trin_VstcoreActionsPaneWord#29](../VS_officedev/codesnippet/VisualBasic/how-to--manage-control-layout-on-actions-panes_4.vb)]  
  
## Compiling the Code  
 This example requires:  
  
-   A Word document-level project with an actions pane that contains multiple user controls or nested actions pane controls.  
  
## See Also  
 [Actions Pane Overview](../VS_officedev/actions-pane-overview.md)   
 [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../VS_officedev/how-to--add-an-actions-pane-to-word-documents-or-excel-workbooks.md)   
 [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../VS_officedev/how-to--add-an-actions-pane-to-word-documents-or-excel-workbooks.md)   
 [Walkthrough: Inserting Text into a Document from an Actions Pane](../VS_officedev/walkthrough--inserting-text-into-a-document-from-an-actions-pane.md)   
 [Walkthrough: Inserting Text into a Document from an Actions Pane](../VS_officedev/walkthrough--inserting-text-into-a-document-from-an-actions-pane.md)  
  
  