---
title: "ATL Encoding Reference"
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
  - "encoding"
  - "encoding, functions"
ms.assetid: 82d4fdf3-3c4a-4fe2-b297-8ffb4714406f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Encoding Reference
Encoding in a range of common Internet standards such as uuencode, hexadecimal, and UTF8 is supported by the code found in atlenc.h.  
  
### Functions  
  
|||  
|-|-|  
|[AtlGetHexValue](../VS_csharp/atlgethexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlHexDecode](../VS_csharp/atlhexdecode.md)|Decodes a string of data that has been encoded as hexadecimal text such as by a previous call to [AtlHexEncode](../VS_csharp/atlhexencode.md).|  
|[AtlHexDecodeGetRequiredLength](../VS_csharp/atlhexdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a hex-encoded string of the specified length.|  
|[AtlHexEncode](../VS_csharp/atlhexencode.md)|Call this function to encode some data as a string of hexadecimal text.|  
|[AtlHexEncodeGetRequiredLength](../VS_csharp/atlhexencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[AtlUnicodeToUTF8](../VS_csharp/atlunicodetoutf8.md)|Call this function to convert a Unicode string to UTF-8.|  
|[BEncode](../VS_csharp/bencode.md)|Call this function to convert some data using the "B" encoding.|  
|[BEncodeGetRequiredLength](../VS_csharp/bencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[EscapeXML](../VS_csharp/escapexml.md)|Call this function to convert characters that are unsafe for use in XML to their safe equivalents.|  
|[GetExtendedChars](../VS_csharp/getextendedchars.md)|Call this function to get the number of extended characters in a string.|  
|[IsExtendedChar](../VS_csharp/isextendedchar.md)|Call this function to find out if a given character is an extended character (less than 32, greater than 126, and not a tab, linefeed or carriage return)|  
|[QEncode](../VS_csharp/qencode.md)|Call this function to convert some data using the "Q" encoding.|  
|[QEncodeGetRequiredLength](../VS_csharp/qencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[QPDecode](../VS_csharp/qpdecode.md)|Decodes a string of data that has been encoded in quoted-printable format such as by a previous call to [QPEncode](../VS_csharp/qpencode.md).|  
|[QPDecodeGetRequiredLength](../VS_csharp/qpdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from quoted-printable-encoded string of the specified length.|  
|[QPEncode](../VS_csharp/qpencode.md)|Call this function to encode some data in quoted-printable format.|  
|[QPEncodeGetRequiredLength](../VS_csharp/qpencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[UUDecode](../VS_csharp/uudecode.md)|Decodes a string of data that has been uuencoded such as by a previous call to [UUEncode](../VS_csharp/uuencode.md).|  
|[UUDecodeGetRequiredLength](../VS_csharp/uudecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a uuencoded string of the specified length.|  
|[UUEncode](../VS_csharp/uuencode.md)|Call this function to uuencode some data.|  
|[UUEncodeGetRequiredLength](../VS_csharp/uuencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
  
### Macros  
  
|||  
|-|-|  
|[ATL_ESC Flags](../VS_csharp/atl_esc-flags.md)|These flags are used to control the behavior of [EscapeXML](../VS_csharp/escapexml.md).|  
|[ATLSMTP_QPENCODE Flags](../VS_csharp/atlsmtp_qpencode-flags.md)|These flags describe how quoted-printable encoding is to be performed by [QPEncode](../VS_csharp/qpencode.md).|  
|[ATLSMTP_UUENCODE Flags](../VS_csharp/atlsmtp_uuencode-flags.md)|These flags describe how uuencoding is to be performed by [UUEncode](../VS_csharp/uuencode.md).|  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)