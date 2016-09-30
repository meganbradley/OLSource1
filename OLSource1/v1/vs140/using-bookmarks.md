---
title: "Using Bookmarks"
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
  - "rowsets, bookmarks"
  - "OLE DB provider templates, bookmarks"
  - "bookmarks, OLE DB"
  - "OLE DB providers, bookmark support"
ms.assetid: 7fa1d1a8-5063-4aa9-93ee-815bb9c98fae
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Bookmarks
Before you open the rowset, you must tell the provider that you want to use bookmarks. To do this, set the **DBPROP_BOOKMARKS** property to **true** in your property set. The provider retrieves bookmarks as column zero, so you must use the special macro `BOOKMARK_ENTRY` and the `CBookmark` class if you are using a static accessor. `CBookmark` is a template class where the argument is the length in bytes of the bookmark buffer. The length of the buffer required for a bookmark depends on the provider. If you are using the ODBC OLE DB provider, as shown in the following example, the buffer must be 4 bytes.  
  
```  
class CProducts  
{  
public:  
   CBookmark<4>   bookmark;  
  
   BEGIN_COLUMN_MAP(CProducts)  
      BOOKMARK_ENTRY(bookmark)  
   END_COLUMN_MAP()  
};  
  
CDBPropSet propset(DBPROPSET_ROWSET);  
propset.AddProperty(DBPROP_BOOKMARKS, true);  
  
CTable<CAccessor<CProducts> > product;  
product.Open(session, "Products", &propset);  
```  
  
 If you use `CDynamicAccessor`, the buffer is dynamically allocated at run time. In this case, you can use a specialized version of `CBookmark` for which you do not specify a buffer length. Use the function `GetBookmark` to retrieve the bookmark from the current record, as shown in this code sample:  
  
```  
CTable<CDynamicAccessor> product;  
CBookmark<>              bookmark;  
CDBPropSet propset(DBPROPSET_ROWSET);  
  
propset.AddProperty(DBPROP_BOOKMARKS, true);  
product.Open(session, "Products", &propset);  
product.MoveNext();  
product.GetBookmark(&bookmark);  
```  
  
 For information about supporting bookmarks in providers, see [Provider Support for Bookmarks](../vs140/provider-support-for-bookmarks.md).  
  
## See Also  
 [Using Accessors](../vs140/using-accessors.md)