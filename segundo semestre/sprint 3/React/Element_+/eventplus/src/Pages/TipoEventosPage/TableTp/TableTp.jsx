import React from 'react';
import './TableTp.css';
import editPen from '../../../assets/images/edit-pen.svg'
import trashDelete from '../../../assets/images/trash-delete.svg'

const TableTp = ({dados, fnUpdate, fnDelete}) => {


  
    
    return (
        <table className='table-data'>
             <thead className="table-data__head">
                <tr className="table-data__head-row">
                    <th className="table-data__head-title table-data__head-title--big">Título</th>
                    <th className="table-data__head-title table-data__head-title--little">Editar</th>
                    <th className="table-data__head-title table-data__head-title--little">Deletar</th>
                </tr>
            </thead>



<tbody>
{dados.map ((tp) => {
            return (
<tr className="table-data__head-row">
          <td className="table-data__data table-data__data--big">
            {tp.titulo}
          </td>

          <td className="table-data__data table-data__data--little">
            <img className="table-data__icon" src={editPen} alt=""
            onClick={() => {
                fnUpdate(tp.idTipoEvento);
            }} />
          </td>
          
          <td className="table-data__data table-data__data--little">
            <img 
            className="table-data__icon" 
            src={trashDelete}
            alt=""
            onClick={() => {
                fnDelete(tp.idTipoEvento)
  
            }} 
            />
          </td>
        </tr>
            )
            //uma linha completa para o cadastro
            
          })}
        
      </tbody>
        </table>
    );
};

export default TableTp;