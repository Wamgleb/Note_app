import React from 'react';
import './App.css';
import { NotesTable } from './components/NotesTable';
import { NewNoteModal } from './components/NoteModal';

const App = () => {
  return (
	<div className="App">
  		<h3>My Notes</h3>
      	<div style={{maxWidth: '70%', margin: 'auto'}}>
		  	<div style={{textAlign: 'right'}}>
				<NewNoteModal />
			</div>
        	<NotesTable />
      	</div>
	</div>
  );
}

export default App;
