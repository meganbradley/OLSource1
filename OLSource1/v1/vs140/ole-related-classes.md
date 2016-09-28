---
title: "OLE-Related Classes"
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
  - "vc.classes.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX classes [C++]"
  - "OLE classes [C++]"
  - "OLE [C++], classes"
ms.assetid: 2135cf54-1d9d-4e0e-91b4-943b3440effa
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OLE-Related Classes
These classes provide a number of different services, ranging from exceptions to file input and output.  
  
 [COleObjectFactory](../vs140/coleobjectfactory-class.md)  
 Used to create items when requested from other containers. This class serves as the base class for more specific types of factories, including `COleTemplateServer`.  
  
 [COleMessageFilter](../vs140/colemessagefilter-class.md)  
 Used to manage concurrency with OLE Lightweight Remote Procedure Calls (LRPC).  
  
 [COleStreamFile](../vs140/colestreamfile-class.md)  
 Uses the COM `IStream` interface to provide `CFile` access to compound files. This class (derived from `CFile`) enables MFC serialization to use OLE structured storage.  
  
 [CRectTracker](../vs140/crecttracker-class.md)  
 Used to allow moving, resizing, and reorientation of in-place items.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)