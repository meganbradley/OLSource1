---
title: "BEGIN_PROPPAGEIDS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "BEGIN_PROPPAGEIDS"
  - "AFXCTL/BEGIN_PROPPAGEIDS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_PROPPAGEIDS macro"
ms.assetid: aed0e026-f2c6-4bb2-a3d5-2aed6e6e1174
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_PROPPAGEIDS
Begins the definition of your control's list of property page IDs.  
  
## Syntax  
  
```  
  
BEGIN_PROPPAGEIDS(  
class_name  
,   
count )  
```  
  
#### Parameters  
 *class_name*  
 The name of the control class for which property pages are being specified.  
  
 *count*  
 The number of property pages used by the control class.  
  
## Remarks  
 In the implementation (.cpp) file that defines the member functions for your class, start the property page list with the `BEGIN_PROPPAGEIDS` macro, then add macro entries for each of your property pages, and complete the property page list with the `END_PROPPAGEIDS` macro.  
  
 For more information on property pages, see the article [ActiveX Controls: Property Pages](../vs140/mfc-activex-controls--property-pages.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [END_PROPPAGEIDS](../vs140/end_proppageids.md)   
 [DECLARE_PROPPAGEIDS](../vs140/declare_proppageids.md)   
 [PROPPAGEID](../vs140/proppageid.md)