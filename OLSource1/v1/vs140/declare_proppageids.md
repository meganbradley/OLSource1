---
title: "DECLARE_PROPPAGEIDS"
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
  - "PROPPAGEID"
  - "DECLARE_PROPPAGEIDS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_PROPPAGEIDS macro"
  - "AFXCTL/DECLARE_PROPPAGEIDS"
  - "PROPPAGEID macro"
ms.assetid: 95c9781a-b64e-4840-8047-c1d1da6c1e24
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_PROPPAGEIDS
Declares that the OLE control provides a list of property pages to display its properties.  
  
## Syntax  
  
```  
  
DECLARE_PROPPAGEIDS(  
class_name )  
```  
  
#### Parameters  
 *class_name*  
 The name of the control class that owns the property pages.  
  
## Remarks  
 Use the `DECLARE_PROPPAGEIDS` macro at the end of your class declaration. Then, in the .cpp file that defines the member functions for the class, use the `BEGIN_PROPPAGEIDS` macro, macro entries for each of your control's property pages, and the `END_PROPPAGEIDS` macro to declare the end of the property page list.  
  
 For more information on property pages, see the article [ActiveX Controls: Property Pages](../vs140/mfc-activex-controls--property-pages.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_PROPPAGEIDS](../vs140/begin_proppageids.md)   
 [END_PROPPAGEIDS](../vs140/end_proppageids.md)