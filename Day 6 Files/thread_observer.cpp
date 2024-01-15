#include <iostream>

using namespace std;

class Subscriber {
public:
    string id;
    string name;

    bool operator==(const Subsciber& compare_with) {
        if (id == compare_with.id && name == compare_with.name) {
            return true;
        }
        else {
            return false;
        }
    }

    void alert(string state) {
        // Use state however you need
    }
};

class Thread {
private:
    string id;
    string state;
    string priority;   // Low, Medium, High
    string culture;

    vector<Subscriber> subscriber_list;

    void notify_subscribers() {
        for (Subscriber subscriber : subscriber_list) {
            subscriber.alert(state);
        }
    }

public:
    Thread() {
        id = "0";
        state = "Created";
        priority = "Low";
        culture = "En-US";
    }

    void start() {
        state = "Running";
        notify_subscribers();
    }

    void abort() {
        state = "Aborted";
        notify_subscribers();
    }

    void sleep(int time_ms) {
        state = "Sleep";
        notify_subscribers();
    }

    void wait() {
        state = "Waiting";
        notify_subscribers();
    }

    void stop() {
        state = "Stopped";
        notify_subscribers();
    }

    void suspend() {
        state = "Suspend";
        notify_subscribers();
    }

    void subscribe(Subscriber subscriber) {
        subscriber_list.push_back(subscriber);
    }

    void unsubscribe(Subscriber subscriber) {
        auto deletion_index = find(subscriber_list.begin(), subscriber_list.end(), subscriber);

        if (deletion_index != subscriber_list.end()) {
            subscriber_list.erase(deletion_index);
        }
    }
};
