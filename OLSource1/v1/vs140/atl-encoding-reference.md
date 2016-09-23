---
title: "ATL Encoding Reference"
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
  - encoding
  - encoding, functions
ms.assetid: 82d4fdf3-3c4a-4fe2-b297-8ffb4714406f
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATL Encoding Reference
Encoding in a range of common Internet standards such as uuencode, hexadecimal, and UTF8 is supported by the code found in atlenc.h.  
  
### Functions  
  
|||  
|-|-|  
|[AtlGetHexValue](../vs140/atlgethexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlHexDecode](../vs140/atlhexdecode.md)|Decodes a string of data that has been encoded as hexadecimal text such as by a previous call to [AtlHexEncode](../vs140/atlhexencode.md).|  
|[AtlHexDecodeGetRequiredLength](../vs140/atlhexdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a hex-encoded string of the specified length.|  
|[AtlHexEncode](../vs140/atlhexencode.md)|Call this function to encode some data as a string of hexadecimal text.|  
|[AtlHexEncodeGetRequiredLength](../vs140/atlhexencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[AtlUnicodeToUTF8](../vs140/atlunicodetoutf8.md)|Call this function to convert a Unicode string to UTF-8.|  
|[BEncode](../vs140/bencode.md)|Call this function to convert some data using the "B" encoding.|  
|[BEncodeGetRequiredLength](../vs140/bencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[EscapeXML](../vs140/escapexml.md)|Call this function to convert characters that are unsafe for use in XML to their safe equivalents.|  
|[GetExtendedChars](../vs140/getextendedchars.md)|Call this function to get the number of extended characters in a string.|  
|[IsExtendedChar](../vs140/isextendedchar.md)|Call this function to find out if a given character is an extended character (less than 32, greater than 126, and not a tab, linefeed or carriage return)|  
|[QEncode](../vs140/qencode.md)|Call this function to convert some data using the "Q" encoding.|  
|[QEncodeGetRequiredLength](../vs140/qencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[QPDecode](../vs140/qpdecode.md)|Decodes a string of data that has been encoded in quoted-printable format such as by a previous call to [QPEncode](../vs140/qpencode.md).|  
|[QPDecodeGetRequiredLength](../vs140/qpdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from quoted-printable-encoded string of the specified length.|  
|[QPEncode](../vs140/qpencode.md)|Call this function to encode some data in quoted-printable format.|  
|[QPEncodeGetRequiredLength](../vs140/qpencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[UUDecode](../vs140/uudecode.md)|Decodes a string of data that has been uuencoded such as by a previous call to [UUEncode](../vs140/uuencode.md).|  
|[UUDecodeGetRequiredLength](../vs140/uudecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a uuencoded string of the specified length.|  
|[UUEncode](../vs140/uuencode.md)|Call this function to uuencode some data.|  
|[UUEncodeGetRequiredLength](../vs140/uuencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
  
### Macros  
  
|||  
|-|-|  
|[ATL_ESC Flags](../vs140/atl_esc-flags.md)|These flags are used to control the behavior of [EscapeXML](../vs140/escapexml.md).|  
|[ATLSMTP_QPENCODE Flags](../vs140/atlsmtp_qpencode-flags.md)|These flags describe how quoted-printable encoding is to be performed by [QPEncode](../vs140/qpencode.md).|  
|[ATLSMTP_UUENCODE Flags](../vs140/atlsmtp_uuencode-flags.md)|These flags describe how uuencoding is to be performed by [UUEncode](../vs140/uuencode.md).|  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)