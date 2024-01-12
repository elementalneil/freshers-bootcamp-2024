#include <iostream>

using namespace std;

class WordDocument {
private:
    vector<DocumentParts> parts;
    IConverter i_converter;
    
public:
    WordDocument {
        i_converter = HTMLConverter();
    }

    void open() {

    }

    void save() {

    }

    void add_part(DocumentParts part) {
        parts.append(part);
    }

    void convert_to_html() {
        for (auto part in parts) {
            i_converter.convert(part);
        }
    }
};


class IConverter {
    virtual void convert(Header header) = 0;
    virtual void convert(Paragraph paragraph) = 0;
    virtual void convert(Hyperlink hyperlink) = 0;
    virtual void convert(Footer footer) = 0;
};


class HTMLConverter {
    void convert(Header header) {

    }

    void convert(Paragraph paragraph) {

    }

    void convert(Hyperlink hyperlink) {

    }

    void convert(Footer footer) {

    }
};


class DocumentParts {
    string name;
    pair<int, int> position;

    virtual void paint() = 0;
    virtual void save() = 0;
    void convert(IConverter i_converter) {
        // call i_converter.convert()
    }
};


class Header : public DocumentParts {
    string title;

    void paint() {

    }

    void save() {

    }
};


class Paragraph : public DocumentParts {
    string content;

    void paint() {

    }

    void save() {

    }
};


class Hyperlink : public DocumentParts {
    string url;
    string text;

    void paint() {

    }

    void save() {

    }
};


class Footer : public DocumentParts {
    string text;

    void paint() {

    }

    void save() {

    }
};
