---
title: "COM_INTERFACE_ENTRY_FUNC_BLIND"
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
  - "COM_INTERFACE_ENTRY_FUNC_BLIND"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_FUNC_BLIND macro"
ms.assetid: 8443ca59-72e6-4cec-ae91-266be0db12db
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_FUNC_BLIND
Same as [COM_INTERFACE_ENTRY_FUNC](../vs140/com_interface_entry_func.md), except that querying for any IID results in a call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A parameter passed through to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The function that gets called when this entry in the COM map is processed.  
  
## Remarks  
 Any failure will cause processing to continue on the COM map. If the function returns an interface pointer, it should return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)