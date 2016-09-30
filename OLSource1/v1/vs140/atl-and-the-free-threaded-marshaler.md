---
title: "ATL and the Free Threaded Marshaler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, free threaded marshaler"
  - "free threaded marshaler"
  - "threading [C++], marshaler in ATL"
  - "threading [ATL], free threaded marshaler"
  - "FTM in ATL"
ms.assetid: 2db88a13-2217-4ebc-aa7e-432d5da902eb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL and the Free Threaded Marshaler
The ATL Simple Object Wizard's Attributes page provides an option that allows your class to aggregate the free threaded marshaler (FTM).  
  
 The wizard generates code to create an instance of the free threaded marshaler in <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and release that instance in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro is automatically added to the COM map to ensure that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> requests for [IMarshal](http://msdn.microsoft.com/library/windows/desktop/dd542707) are handled by the free threaded marshaler.  
  
 The free threaded marshaler allows direct access to interfaces on your object from any thread in the same process, speeding up cross-apartment calls. This option is intended for classes that use the Both threading model.  
  
 When using this option, classes must take responsibility for the thread-safety of their data. In addition, objects that aggregate the free threaded marshaler and need to use interface pointers obtained from other objects must take extra steps to ensure that the interfaces are correctly marshaled. Typically this involves storing the interface pointers in the global interface table (GIT) and getting the pointer from the GIT each time it is used. ATL provides the class [CComGITPtr](../vs140/ccomgitptr-class.md) to help you use interface pointers stored in the GIT.  
  
## See Also  
 [Concepts](../vs140/active-template-library--atl--concepts.md)   
 [CoCreateFreeThreadedMarshaler](http://msdn.microsoft.com/library/windows/desktop/ms694500)   
 [IMarshal](http://msdn.microsoft.com/library/windows/desktop/dd542707)   
 [When to Use the Global Interface Table](http://msdn.microsoft.com/library/windows/desktop/ms693729)   
 [In-Process Server Threading Issues](http://msdn.microsoft.com/library/windows/desktop/ms687205)