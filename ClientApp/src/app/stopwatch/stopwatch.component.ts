import { Component, OnInit } from '@angular/core';
import Times from '../interfaces/times';

@Component({
  selector: 'app-stopwatch',
  templateUrl: './stopwatch.component.html',
  styleUrls: ['./stopwatch.component.css']
})
export class StopwatchComponent implements OnInit {

  running: boolean;
  laps: Times[];
  times: Times;
  time: number;

  results: any[];
  stopwatch: string;

  constructor() {
    this.running = false;
    this.laps = [];
    this.results = [];
  }

  ngOnInit() {
    this.reset();
    this.print();
  }

  start() {
    if (!this.time) this.time = performance.now();
    if (!this.running) {
      this.running = true;
      requestAnimationFrame(this.step.bind(this));
    }
  }

  reset() {
    this.times = {
      milliseconds: 0,
      seconds: 0,
      minutes: 0,
      hours: 0
    };
  }

  lap() {
    if (!this.running) {
      return;
    }
    var newTime = this.iterationCopy(this.times);
    this.results.push(newTime);
  }

  stop() {
    this.running = false;
    this.time = null;
  }

  restart() {
    if (!this.time) this.time = performance.now();
    requestAnimationFrame(this.step.bind(this));
    this.reset();
    this.print();
  }

  clear() {
    this.results = [];
  }

  private step(timestamp: number) {
    if (!this.running) return;
    this.calculate(timestamp);
    this.time = timestamp;
    this.print();
    requestAnimationFrame(this.step.bind(this));
  }

  private calculate(timestamp: number) {
    var diff = timestamp - this.time;

    this.times.milliseconds += diff / 10;

    if (this.times.milliseconds >= 100) {
      this.times.seconds += 1;
      this.times.milliseconds = 0;
    }

    if (this.times.seconds >= 60) {
      this.times.minutes += 1;
      this.times.seconds = 0;
    }

    if (this.times.minutes >= 60) {
      this.times.hours += 1;
      this.times.minutes = 0;
    }
  }

  private print() {
    this.stopwatch = this.format(this.times);
  }

  private format(time: Times) {
    return `${this.pad0(time.hours, 2)}:${this.pad0(time.minutes, 2)}:${this.pad0(time.seconds, 2)}:${this.pad0(Math.floor(time.milliseconds), 2)}`;
  }

  private pad0(value: number, maxLength: number): string {
    return value.toString().padStart(maxLength, '0');
  }

  private iterationCopy(src: any): any {
    let target = {};
    for (let prop in src) {
      if (src.hasOwnProperty(prop)) {
        target[prop] = src[prop];
      }
    }
    return target;
  }

}

