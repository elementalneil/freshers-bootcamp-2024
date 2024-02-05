#include <iostream>
#include <memory>

using namespace std;


class ITransmission;
class IEngine;
class IFuelPump;
class IStartupMotor;


class DIContainer {
public:
    template<typename T>
    static shared_ptr<T> resolve() {
        return make_shared<T>();
    }
};


class Car {
private:
    shared_ptr<ITransmission> transmission;
    shared_ptr<IEngine> engine;

public:
    Car(shared_ptr<ITransmission> transmission_input, shared_ptr<IEngine> engine_input)
        : transmission(transmission_input), engine(engine_input) {}

    void start() {
        engine->start();
    }
};


class ITransmission {
public:
    virtual void shift_up() = 0;
    virtual void shift_down() = 0;
};

class IEngine {
public:
    virtual void start() = 0;
    virtual void accelerate() = 0;
};

class IFuelPump {
public:
    virtual void inject_fuel(float volume_cc) = 0;
};

class IStartupMotor {
public:
    virtual void start() = 0;
};


class Transmission : public ITransmission {
private:
    char current_gear;

public:
    Transmission() : current_gear('N') {}

    void shift_up() override {
        // Implementation
    }

    void shift_down() override {
        // Implementation
    }

    void reverse() {
        current_gear = 'R';
    }
};


class Engine : public IEngine {
private:
    int capacity_cc;
    shared_ptr<IFuelPump> fuel_pump;
    shared_ptr<IStartupMotor> startup_motor;

public:
    Engine(shared_ptr<IFuelPump> fuel_pump_input, shared_ptr<IStartupMotor> startup_motor_input, int engine_capacity)
        : fuel_pump(fuel_pump_input), startup_motor(startup_motor_input), capacity_cc(engine_capacity) {}

    void start() override {
        fuel_pump->inject_fuel(capacity_cc);
        startup_motor->start();
        // Perform the rest of the actions to start the engine
    }

    void accelerate() override {
        // Accelerate
    }
};


class FuelPump : public IFuelPump {
public:
    void inject_fuel(float volume_cc) override {
        // Inject Fuel
    }
};

class StartupMotor : public IStartupMotor {
public:
    void start() override {
        // Start
    }
};

int main() {
    DIContainer::resolve<Transmission>();
    DIContainer::resolve<FuelPump>();
    DIContainer::resolve<StartupMotor>();

    shared_ptr<Car> car = DIContainer::resolve<Car>();

    car->start();

    return 0;
}