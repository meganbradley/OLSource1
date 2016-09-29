---
title: "CHtmlView::OnFilterDataObject"
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
  - "OnFilterDataObject"
  - "CHtmlView::OnFilterDataObject"
  - "CHtmlView.OnFilterDataObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFilterDataObject method"
ms.assetid: 4fdbe6b1-808d-4bae-9fc4-e46b01d7fb38
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnFilterDataObject
Called on the host by Internet Explorer or MSHTML to allow the host to replace Internet Explorer or MSHTML's data object.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnFilterDataObject(  
   LPDATAOBJECT pDataObject,  
   LPDATAOBJECT* ppDataObject   
);  
```  
  
#### Parameters  
 `pDataObject`  
 Address of the [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) interface supplied by Internet Explorer or MSHTML.  
  
 *ppDataObject*  
 Address that receives the `IDataObject` interface pointer supplied by the host. The contents of this parameter should always be initialized to **NULL**, even if the method fails.  
  
## Return Value  
 `S_OK` if the data object is replaced, **S_FALSE** if the data object is not replaced, or an OLE-defined error code if an error occurs.  
  
## Remarks  
 Override `OnFilterDataObject` to react to the `FilterDataObject` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::FilterDataObject](https://msdn.microsoft.com/en-us/library/aa753254.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)