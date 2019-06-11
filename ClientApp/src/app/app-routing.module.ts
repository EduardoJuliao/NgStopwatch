import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StopwatchComponent } from './stopwatch/stopwatch.component';

const routes: Routes = [
  { path: 'home', component: StopwatchComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
