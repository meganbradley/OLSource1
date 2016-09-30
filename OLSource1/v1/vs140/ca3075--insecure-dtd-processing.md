---
title: "CA3075: Insecure DTD Processing"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 65798d66-7a30-4359-b064-61a8660c1eed
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA3075: Insecure DTD Processing
|||  
|-|-|  
|TypeName|InsecureDTDProcessing|  
|CheckId|CA3075|  
|Category|Microsoft.Security|  
|Breaking Change|Non Breaking|  
  
## Cause  
 If you use insecure \<xref:System.Xml.XmlReaderSettings.DtdProcessing*> instances or reference external entity sources, the parser may accept untrusted input and disclose sensitive information to attackers.  
  
## Rule Description  
 A [Document Type Definition (DTD)](https://msdn.microsoft.com/en-us/library/aa468547.aspx) is one of two ways an XML parser can determine the validity of a document, as defined by the  [World Wide Web Consortium (W3C) Extensible Markup Language (XML) 1.0](http://www.w3.org/TR/2008/REC-xml-20081126/). This rule seeks properties and instances where untrusted data is accepted to warn developers about potential [Information Disclosure](assetId:///4064c89f-afa6-444a-aa7e-807ef072131c) threats, which may lead to [Denial of Service (DoS)](assetId:///dfb150f3-d598-4697-a5e6-6779e4f9b600) attacks. This rule triggers when:  
  
-   DtdProcessing is enabled on the \<xref:System.Xml.XmlReader*> instance, which resolves external XML entities using \<xref:System.Xml.XmlUrlResolver*>.  
  
-   The \<xref:System.Xml.XmlNode.InnerXml*> property in the XML is set.  
  
-   \<xref:System.Xml.XmlReaderSettings.DtdProcessing*> property is set  to Parse    .  
  
-   Untrusted input is processed using \<xref:System.Xml.XmlResolver*> instead of \<xref:System.Xml.XmlSecureResolver*> .  
  
-   The XmlReader.\<xref:System.Xml.XmlReader.Create*> method is invoked with an insecure \<xref:System.Xml.XmlReaderSettings*> instance or no instance at all.  
  
-   \<xref:System.Xml.XmlReader*> is created with insecure default settings or values    .  
  
 In each of these cases, the outcome is the same: the contents from either the file system or network shares from the machine where the XML is processed will be exposed to the attacker, which may then be used as a DoS vector.  
  
## How to Fix Violations  
  
-   Catch and process all XmlTextReader exceptions properly to avoid path information disclosure    .  
  
-   Use the \<xref:System.Xml.XmlSecureResolver*> to restrict the resources      that the XmlTextReader can access.  
  
-   Do not allow the \<xref:System.Xml.XmlReader*> to open any external resources by setting the \<xref:System.Xml.XmlResolver*> property to **null**.  
  
-   Ensure that the \<xref:System.Data.DataViewManager.DataViewSettingCollectionString*> property of \<xref:System.Data.DataViewManager*> is assigned from a trusted source.  
  
 .NET 3.5 and earlier  
  
-   Disable DTD processing if you are dealing with untrusted sources by setting the \<xref:System.Xml.XmlReaderSettings.ProhibitDtd*> property to **true** .  
  
-   XmlTextReader class has a full trust inheritance demand. See [Inheritance Demands](assetId:///28b9adbb-8f08-4f10-b856-dbf59eb932d9) for more information    .  
  
 .NET 4 and later  
  
-   Avoid enabling DtdProcessing if you're dealing with untrusted sources by setting the DtdProcessing  property to [Prohibit or Ignore](https://msdn.microsoft.com/en-us/library/system.xml.dtdprocessing.aspx)  
  
-   Ensure that the Load() method takes an XmlReader instance in all InnerXml cases.  
  
> [!NOTE]
>  This rule might report false positives on some valid XmlSecureResolver instances. We're working on solving this issue by mid 2016.  
  
## When to Suppress Warnings  
 Unless you're sure that the input is known to be from a trusted source, do not suppress a rule from this warning.  
  
## Pseudo-code Examples  
  
### Violation  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Violation  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Violations  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Violation  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Violation  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Violation  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Violations  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Solution  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>