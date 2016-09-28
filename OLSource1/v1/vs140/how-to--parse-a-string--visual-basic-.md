---
title: "How to: Parse a String (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 896e1b4b-f9bd-4975-8bc1-55b6badce1ac
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
---
# How to: Parse a String (Visual Basic)
This topic shows how to create an XML tree in C#.  
  
## Example  
 You can parse a string in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] by using the `XElement.Parse` method. However, it is more efficient to use XML literals, as shown in following code, because XML literals do not suffer from the same performance penalties as parsing XML from a string.  
  
 By using XML literals, you can just copy and paste your XML into your [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program.  
  
> [!NOTE]
>  Parsing text or loading an XML document from a text file is less efficient than functional construction. If you are initializing an XML tree from code, it takes less processor time to use functional construction than to parse text.  
  
```vb  
Dim contacts as XElement = _  
    <Contacts>  
        <Contact>  
            <Name>Patrick Hines</Name>  
            <Phone Type="home">206-555-0144</Phone>  
            <Phone Type="work">425-555-0145</Phone>  
            <Address>  
            <Street1>123 Main St</Street1>  
            <City>Mercer Island</City>  
            <State>WA</State>  
            <Postal>68042</Postal>  
            </Address>  
            <NetWorth>10</NetWorth>  
        </Contact>  
        <Contact>  
            <Name>Gretchen Rivas</Name>  
            <Phone Type="mobile">206-555-0163</Phone>  
            <Address>  
            <Street1>123 Main St</Street1>  
            <City>Mercer Island</City>  
            <State>WA</State>  
            <Postal>68042</Postal>  
            </Address>  
            <NetWorth>11</NetWorth>  
        </Contact>  
    </Contacts>  
```  
  
## See Also  
 [Parsing XML (Visual Basic)](../vs140/parsing-xml--visual-basic-.md)