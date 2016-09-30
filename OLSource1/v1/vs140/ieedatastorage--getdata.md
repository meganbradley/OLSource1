---
title: "IEEDataStorage::GetData"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IEEDataStorage::GetData"
helpviewer_keywords: 
  - "IEEDataStorage::GetData"
ms.assetid: 4d384039-73d4-40b4-ace6-a2474c546397
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEDataStorage::GetData
Retrieves the specified number of bytes from the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The number of bytes to retrieve (the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array must hold at least this number of bytes).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes actually retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] Array to be filled in with the requested data.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The recommended use of this method is to retrieve all the data bytes into a local array, since there is no way to skip over bytes in the retrieval process. In this case, the parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> should be the value returned by the [IEEDataStorage::GetSize](../vs140/ieedatastorage--getsize.md) method.  
  
## See Also  
 [IEEDataStorage](../vs140/ieedatastorage.md)   
 [IEEDataStorage::GetSize](../vs140/ieedatastorage--getsize.md)