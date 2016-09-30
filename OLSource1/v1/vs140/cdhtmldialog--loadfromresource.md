---
title: "CDHtmlDialog::LoadFromResource"
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
  - "CDHtmlDialog::LoadFromResource"
  - "CDHtmlDialog.LoadFromResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadFromResource method"
ms.assetid: 6bf9c93e-80cc-4fc6-a4e0-6b3a09cc5665
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::LoadFromResource
Loads the specified resource into the WebBrowser control in the DHTML dialog.  
  
## Syntax  
  
```  
  
      BOOL LoadFromResource(  
   LPCTSTR lpszResource   
);  
BOOL LoadFromResource(  
   UINT nRes   
);  
```  
  
#### Parameters  
 `lpszResource`  
 A pointer to a string containing the name of the resource to load.  
  
 `nRes`  
 The ID of the resource to load.  
  
## Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)