#include <iostream>

using namespace std;


class Car {
private:
    ITransmission *transmission;
    IEngine *engine;

public:
    Car(ITransmission *transmission_input, IEngine *engine_input) {
        transmission = transmission_input;
        engine = engine_input;
    }

    void start() {
        (*engine).start();
    }
};


class ITransmission {
protected:
    char current_gear;

public:
    virtual void shift_up() = 0;
    virtual void shift_down() = 0;
};


class IEngine {
protected:
    int capacity_cc;
    IFuelPump *fuel_pump;
    IStartupMotor *startup_motor;

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


class Transmission : private ITransmission {
    Transmission() {
        current_gear = 'N';
    }

    void shift_up() {
        if (current_gear != '5') {
            if (current_gear == 'R' || current_gear == 'N') {
                current_gear = '1';
            }
            else {
                current_gear = current_gear + 1;
            }
        }
    }

    void shift_down() {
        if (current_gear != 'R' && current_gear != 'N') {
            if (current_gear == '1') {
                current_gear = 'N';
            }
            else {
                current_gear = current_gear - 1;
            }
        }
    }

    void reverse() {
        current_gear = 'R';
    }
};


class Engine : private IEngine {
public:
    Engine(IFuelPump *fuel_pump_input, IStartupMotor *startup_motor_input, int engine_capacity) {
        fuel_pump = fuel_pump_input;
        startup_motor = startup_motor_input;
        capacity_cc = engine_capacity;
    }

    void start() {
        (*fuel_pump).inject_fuel(capacity_cc);
        (*startup_motor).start();
        // Perform Rest of Actions to Start Engine
    }

    void accelerate() {
        // Accelerate
    }
};


class FuelPump : private IFuelPump {
public:
    void inject_fuel(float volume_cc) {
        // Inject Fuel
    }
};


class StartupMotor : private IStartupMotor {
public:
    void start() {
        // Start
    }
};