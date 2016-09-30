---
title: "ungetc, ungetwc"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "ungetwc"
  - "ungetc"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ungettc"
  - "ungetwc"
  - "ungetc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ungetwc function"
  - "ungettc function"
  - "characters, pushing back onto stream"
  - "_ungettc function"
  - "ungetc function"
ms.assetid: e0754f3a-b4c6-408f-90c7-e6387b830d84
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ungetc, ungetwc
Pushes a character back onto the stream.  
  
## Syntax  
  
```  
int ungetc(  
   int c,  
   FILE *stream   
);  
wint_t ungetwc(  
   wint_t c,  
   FILE *stream   
);  
```  
  
#### Parameters  
 `c`  
 Character to be pushed.  
  
 `stream`  
 Pointer to `FILE` structure.  
  
## Return Value  
 If successful, each of these functions returns the character argument `c`*.* If `c` cannot be pushed back or if no character has been read, the input stream is unchanged and `ungetc` returns `EOF`; `ungetwc` returns `WEOF`. If `stream` is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, `EOF` or `WEOF` is returned and `errno` is set to `EINVAL`.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The `ungetc` function pushes the character `c` back onto `stream` and clears the end-of-file indicator. The stream must be open for reading. A subsequent read operation on `stream` starts with `c`*.* An attempt to push `EOF` onto the stream using `ungetc` is ignored.  
  
 Characters placed on the stream by `ungetc` may be erased if `fflush`, `fseek`, `fsetpos`, or `rewind` is called before the character is read from the stream. The file-position indicator will have the value it had before the characters were pushed back. The external storage corresponding to the stream is unchanged. On a successful `ungetc` call against a text stream, the file-position indicator is unspecified until all the pushed-back characters are read or discarded. On each successful `ungetc` call against a binary stream, the file-position indicator is decremented; if its value was 0 before a call, the value is undefined after the call.  
  
 Results are unpredictable if `ungetc` is called twice without a read or file-positioning operation between the two calls. After a call to `fscanf`, a call to `ungetc` may fail unless another read operation (such as `getc`) has been performed. This is because `fscanf` itself calls `ungetc`.  
  
 `ungetwc` is a wide-character version of `ungetc`. However, on each successful `ungetwc` call against a text or binary stream, the value of the file-position indicator is unspecified until all pushed-back characters are read or discarded.  
  
 These functions are thread-safe and lock sensitive data during execution. For a non-locking version, see [_ungetc_nolock, _ungetwc_nolock](../vs140/_ungetc_nolock--_ungetwc_nolock.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_ungettc`|`ungetc`|`ungetc`|`ungetwc`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`ungetc`|\<stdio.h>|  
|`ungetwc`|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—`stdin`, `stdout`, and `stderr`—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_ungetc.c  
// This program first converts a character  
// representation of an unsigned integer to an integer. If  
// the program encounters a character that is not a digit,  
// the program uses ungetc to replace it in the  stream.  
//  
  
#include <stdio.h>  
#include <ctype.h>  
  
int main( void )  
{  
   int ch;  
   int result = 0;  
  
   // Read in and convert number:  
   while( ((ch = getchar()) != EOF) && isdigit( ch ) )  
      result = result * 10 + ch - '0';    // Use digit.  
   if( ch != EOF )  
      ungetc( ch, stdin );                // Put nondigit back.  
   printf( "Number = %d\nNext character in stream = '%c'",   
            result, getchar() );  
}  
```  
  
  **`521a`Number = 521**  
**Next character in stream = 'a'**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [putc, putwc](../vs140/putc--putwc.md)