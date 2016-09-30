---
title: "CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog"
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
  - "CMFCToolBarsCustomizeDialog"
  - "CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog"
  - "CMFCToolBarsCustomizeDialog.CMFCToolBarsCustomizeDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarsCustomizeDialog, constructor"
ms.assetid: 8a4555db-4611-468e-8b1f-dd8db8006641
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the parent frame. This parameter must not be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to add the menu commands from all menus to the list of commands on the **Commands** page. If this parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the menu commands are added. Otherwise, the menu commands are not added.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A combination of flags that affect the behavior of the dialog box. This parameter can be one or more of the following values:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to a list of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects that specify additional custom pages.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter refers to the list of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects that specify additional custom pages. The constructor adds more pages to the dialog box by using the [CRuntimeClass::CreateObject](../vs140/cruntimeclass--createobject.md) method. See the CustomPages sample for an example that adds more pages to the **Customize** dialog box.  
  
 For more information about the values that you can pass in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter, see [CMFCToolBarsCustomizeDialog::GetFlags](../vs140/cmfctoolbarscustomizedialog--getflags.md).  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#3](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog--cmfctoolbarscustomizedialog_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CRuntimeClass::CreateObject](../vs140/cruntimeclass--createobject.md)   
 [CMFCToolBarsCustomizeDialog::GetFlags](../vs140/cmfctoolbarscustomizedialog--getflags.md)