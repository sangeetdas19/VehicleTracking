import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { interval } from 'rxjs';
import { takeWhile } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Vehicle Tracking';

  // google maps zoom level
  zoom: number = 16;

  // initial center position for the map

  currentPos: point = {
    lat: 50.082730,
    lng: 14.431697
  };
  points: point[] = [];
  tmpPoints: point[] = [
    this.currentPos,
    {
      lat: 50.082911,
      lng: 14.431411
    },
    {
      lat: 50.083202,
      lng: 14.430994
    },
    {
      lat: 50.083352,
      lng: 14.430780
    },
    {
      lat: 50.083491,
      lng: 14.430569
    },
    {
      lat: 50.083644,
      lng: 14.430367
    }

  ];

  ngOnInit() {
    let i = 0;
    const pos = this.tmpPoints[0];
    this.points.push(pos);
    this.currentPos = pos;
  }


}

// just an interface for type safety.
interface point {
  lat: number;
  lng: number;
}
