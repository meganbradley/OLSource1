---
title: "CMFCToolBarsCustomizeDialog::GetFlags"
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
  - "CMFCToolBarsCustomizeDialog.GetFlags"
  - "GetFlags"
  - "CMFCToolBarsCustomizeDialog::GetFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFlags method"
ms.assetid: 0bb401bd-35a7-492f-b7e8-334833332912
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::GetFlags
Retrieves the set of flags that affect the behavior of the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The set of flags that affect the behavior of the dialog box.  
  
## Remarks  
 This method retrieves the value of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter that is passed to the constructor. The return value can be one or more of the following values:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Allows the user to specify the shadow appearance of the menu.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Allows the user to specify whether text labels are shown underneath the toolbar button images.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Allows the user to specify the menu animation style.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Removes the help button from the customization dialog box.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Enables the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> visual style.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Removes the **Tools** page from the customization dialog box. This flag is valid if your application uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Allows button captions to contain the ampersand (**&**) character.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Removes the **Large Icons** option from the customization dialog box.  
  
 For more information about the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> visual style, see [Extended Window Styles](../vs140/extended-window-styles.md).  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog--cmfctoolbarscustomizedialog.md)   
 [Extended Window Styles](../vs140/extended-window-styles.md)   
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)