#include <iostream>

using namespace std;

class WordDocument {
    vector<DocumentParts> parts;
    
    void open() {

    }

    void save() {

    }
};


class DocumentParts {
    string name;
    pair<int, int> position;

    virtual void paint() = 0;
    virtual void save() = 0;
};


class Header {
    string title;

    void paint() {

    }

    void save() {

    }
};


class Paragraph {
    string content;

    void paint() {

    }

    void save() {

    }
};


class Hyperlink {
    string url;
    string text;

    void paint() {

    }

    void save() {

    }
};


class Footer {
    string text;

    void paint() {

    }

    void save() {

    }
};