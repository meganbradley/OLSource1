---
title: "Storing Strings in the OLE DB Provider"
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
  - "user records, editing"
ms.assetid: 36cb9635-067c-4cad-8f85-962f28026f6a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storing Strings in the OLE DB Provider
In MyProviderRS.h, the ATL OLE DB Provider Wizard creates a default user record called <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. To handle the two strings, either modify <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or add your own user record as shown in the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The data members <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represent the two strings, with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> providing additional columns if needed. The data member <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not needed for this simple read-only provider but is used later to add an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface; see [Enhancing the Simple Read Only Provider](../vs140/enhancing-the-simple-read-only-provider.md). The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator compares instances (implementing this operator is optional).  
  
 When this is done, your provider should be ready to compile and run. To test the provider, you need a consumer with matching functionality. [Implementing a Simple Consumer](../vs140/implementing-a-simple-consumer.md) shows how to create such a test consumer. Run the test consumer with the provider. Verify that the test consumer retrieves the proper strings from the provider when you click the **Run** button in the **Test Consumer** dialog box.  
  
 When you have successfully tested your provider, you might want to enhance its functionality by implementing additional interfaces. An example is shown in [Enhancing the Simple Read-Only Provider](../vs140/enhancing-the-simple-read-only-provider.md).  
  
## See Also  
 [Implementing the Simple Read-Only Provider](../vs140/implementing-the-simple-read-only-provider.md)