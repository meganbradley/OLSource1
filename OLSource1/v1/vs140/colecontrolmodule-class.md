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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This class provides member functions for initializing your control module. Each OLE control module that uses the Microsoft Foundation classes can only contain one object derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. This object is constructed when other C++ global objects are constructed. Declare your derived <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object at the global level.  
  
 For more information on using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class, see the [CWinApp](../vs140/cwinapp-class.md) class and the article [ActiveX Controls](../vs140/mfc-activex-controls.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWinThread](../vs140/cwinthread-class.md)  
  
 [CWinApp](../vs140/cwinapp-class.md)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [MFC Sample TESTHELP](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)