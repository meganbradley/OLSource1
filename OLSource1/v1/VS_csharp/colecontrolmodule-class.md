---
title: "COleControlModule Class"
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
  - "COleControlModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE control modules"
  - "MFC ActiveX controls, OLE control modules"
  - "COleControlModule class"
  - "control modules"
ms.assetid: 0721724d-d4af-4eda-ad34-5a2b27810dd4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlModule Class
The base class from which you derive an OLE control module object.  
  
## Syntax  
  
```  
class COleControlModule : public CWinApp  
```  
  
## Remarks  
 This class provides member functions for initializing your control module. Each OLE control module that uses the Microsoft Foundation classes can only contain one object derived from `COleControlModule`. This object is constructed when other C++ global objects are constructed. Declare your derived `COleControlModule` object at the global level.  
  
 For more information on using the `COleControlModule` class, see the [CWinApp](../VS_csharp/cwinapp-class.md) class and the article [ActiveX Controls](../VS_csharp/mfc-activex-controls.md).  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CWinThread](../VS_csharp/cwinthread-class.md)  
  
 [CWinApp](../VS_csharp/cwinapp-class.md)  
  
 `COleControlModule`  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [MFC Sample TESTHELP](../VS_csharp/visual-c---samples.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)