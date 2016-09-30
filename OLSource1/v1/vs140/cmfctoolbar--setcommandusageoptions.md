---
title: "CMFCToolBar::SetCommandUsageOptions"
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
  - "CMFCToolBar.SetCommandUsageOptions"
  - "CMFCToolBar::SetCommandUsageOptions"
  - "SetCommandUsageOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCommandUsageOptions method"
ms.assetid: 40bf7504-5dbb-4a5e-9db4-a02225b8072f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetCommandUsageOptions
Specifies when rarely used commands do not appear in the menu of the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of times that commands must be executed before the framework shows only the basic and recently-used commands.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The percentage of times that a command must be executed to be considered a recently-used command.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is equal to or larger than 100; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to customize the algorithm that the framework uses to determine how basic and recently used menu items appear. For more information about basic commands, see [CMFCToolBar::AddBasicCommand](../vs140/cmfctoolbar--addbasiccommand.md).  
  
 This class uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class to track the usage count of commands. For more information about this class, see [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::AddBasicCommand](../vs140/cmfctoolbar--addbasiccommand.md)   
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)