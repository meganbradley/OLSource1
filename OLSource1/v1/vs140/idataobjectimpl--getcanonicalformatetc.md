---
title: "IDataObjectImpl::GetCanonicalFormatEtc"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - IDataObjectImpl.GetCanonicalFormatEtc
  - GetCanonicalFormatEtc
  - IDataObjectImpl::GetCanonicalFormatEtc
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCanonicalFormatEtc method
ms.assetid: 637921a8-020a-4eb9-9370-9408948cca65
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDataObjectImpl::GetCanonicalFormatEtc
Retrieves a logically equivalent **FORMATETC** structure to one that is more complex.  
  
## Syntax  
  
```  
  
      HRESULT GetCanonicalFormatEtc(  
   FORMATETC* pformatetcIn,  
   FORMATETC* pformatetcOut   
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IDataObject::GetCanonicalFormatEtc](http://msdn.microsoft.com/library/windows/desktop/ms680685) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IDataObjectImpl Class](../vs140/idataobjectimpl-class.md)   
 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177)