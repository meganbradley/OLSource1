---
title: "CPaneDialog::Create"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "Create"
  - "CPaneDialog::Create"
  - "CPaneDialog.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: bd7499e3-4273-4705-8bca-719b512c668a
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneDialog::Create
Creates a docking dialog box and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the docking dialog box.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the parent window.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to create the docking dialog box with a caption (gripper); otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The name of the resource dialog template.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The Windows style.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The control ID.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The resource ID of the dialog template.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The style of the tabbed window that results when the user drags another control pane onto the caption of this control pane. The default value is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane--createex.md) method.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Additional style attributes. The default value is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane--createex.md) method.  
  
## Return Value  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if this method succeeds; otherwise, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class. This example is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#2](../vs140/codesnippet/CPP/cpanedialog--create_1.h)]  
[!code[NVC_MFC_SetPaneSize#3](../vs140/codesnippet/CPP/cpanedialog--create_2.cpp)]  
  
## Requirements  
 **Header:** afxpanedialog.h  
  
## See Also  
 [CPaneDialog Class](../vs140/cpanedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)