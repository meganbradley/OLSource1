class CMySink : public CCmdTarget
{
public:
   CMySink();
   ~CMySink() {};

protected:
   DECLARE_INTERFACE_MAP()

   // The following block declares an inner class called 'XSinky'
   BEGIN_INTERFACE_PART(Sinky, ISampleSink)
      STDMETHOD(SinkFunc)();
   END_INTERFACE_PART(Sinky)
};