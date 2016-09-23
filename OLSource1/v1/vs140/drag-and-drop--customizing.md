---
title: "Drag and Drop: Customizing"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - drag and drop, implementing in non-OLE applications
  - drag and drop, customizing behavior
  - drag and drop, COleDataSource object
  - drag and drop, calling DoDragDrop
  - OLE drag and drop, customizing behavior
ms.assetid: 03369d3e-46bf-4140-b58c-d0c9657cf38a
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Drag and Drop: Customizing
The default implementation of the drag-and-drop feature is sufficient for most applications. However, some applications may require that this standard behavior be changed. This article explains the steps necessary to change these defaults. In addition, you can use this technique to establish applications that do not support compound documents as drop sources.  
  
 If you are customizing standard OLE drag-and-drop behavior, or you have a non-OLE application, you must create a `COleDataSource` object to contain the data. When the user starts a drag-and-drop operation, your code should call the `DoDragDrop` function from this object instead of from other classes that support drag-and-drop operations.  
  
 Optionally, you can create a `COleDropSource` object to control the drop and override some of its functions depending on the type of behavior you want to change. This drop-source object is then passed to `COleDataSource::DoDragDrop` to change the default behavior of these functions. These different options allow a great deal of flexibility in how you support drag-and-drop operations in your application. For more information about data sources, see the article [Data Objects and Data Sources (OLE)](../vs140/data-objects-and-data-sources--ole-.md).  
  
 You can override the following functions to customize drag-and-drop operations:  
  
|Override|To customize|  
|--------------|------------------|  
|`OnBeginDrag`|How dragging is initiated after you call `DoDragDrop`.|  
|`GiveFeedback`|Visual feedback, such as cursor appearance, for different drop results.|  
|`QueryContinueDrag`|The termination of a drag-and-drop operation. This function enables you to check modifier key states during the drag operation.|  
  
## See Also  
 [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md)   
 [COleDropSource Class](../vs140/coledropsource-class.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)