using FactoryMethodPattern.Documents;

namespace FactoryMethodPattern.Factories
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}
